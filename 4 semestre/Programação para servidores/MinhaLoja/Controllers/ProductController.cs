using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaLoja.Attributes;
using MinhaLoja.Data;
using MinhaLoja.Models;
using MinhaLoja.ViewModel;

namespace MinhaLoja.Controllers
{
    //[ApiKey]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Authorize(Roles = "Cliente, Admin")]        
        [HttpGet("product")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDbContext context,
            [FromQuery] int page = 0,
            [FromQuery] int pageSize = 10)
        {
            try
            {
                // total de registros
                var count = await context.Products.CountAsync();

                // Consulta na tabela de produtos
                var products = await context
                    .Products
                    .Include(c => c.Category)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return Ok(new
                {
                    total = count,
                    page,
                    pageSize,
                    products
                });
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor" });
            }
        }


        [Authorize(Roles = "Cliente, Admin")]
        [HttpPost("product")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] ProductCreateViewModel model)
        {
            try
            {
                var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == model.CategoryId);

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

                await context.Products.AddAsync(product);
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