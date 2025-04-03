using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaLoja.Data;
using MinhaLoja.Models;
using MinhaLoja.ViewModel;

namespace MinhaLoja.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Authorize(Roles = "Cliente, Admin")]
        [HttpGet("product")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {
            try
            {
                var products = await context.tabProducts.Include(x => x.Category).ToListAsync();

                return Ok(products);
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor" });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("product")]
        public async Task<IActionResult> PostAsync([FromServices] AppDbContext context, [FromBody] ProductCreateViewModel model)
        {
            try
            {
                var category = await context.tabCategories.FirstOrDefaultAsync(x => x.Id == model.CategoryId);

                if (category == null)
                    return StatusCode(401, new { message = "Categoria inválida" });

                var product = new Product
                {
                    Name = model.Name,
                    Value = model.Value,
                    Description = model.Description,
                    Image = model.Image,
                    Category = category
                };

                await context.tabProducts.AddAsync(product);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor" });
            }
        }
    }
}