using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MinhaLoja.Data;
using System.Text.RegularExpressions;
using TP___Cache_n_Image.Models;
using TP___Cache_n_Image.ViewModels;

namespace TP___Cache_n_Image.Controllers
{
    public class ContatoController : ControllerBase
    {
        [HttpGet("contato")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context, [FromServices] IMemoryCache cache, [FromQuery] int page = 0, [FromQuery] int pageSize = 10)
        {
            try
            {
                var count = await cache.GetOrCreateAsync("ContatoCache", async entry =>
                {
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1);
                    return await context.TabContato.CountAsync();
                });

                var contatos = await context.TabContato.Skip(page * pageSize).Take(pageSize).ToListAsync();

                return Ok(new
                {
                    total = count,
                    page,
                    pageSize,
                    contatos
                });
            }
            catch
            {
                return StatusCode(500, new { message = "Falha interna no servidor"});
            }
        }

        [HttpPost("contato")]
        public async Task<IActionResult> PostAsync([FromServices] AppDbContext context, [FromBody] ContatoCreateViewModel model)
        {
            try
            {
                var fileName = $"{Guid.NewGuid()}.jpg";
                var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(model.Imagem, "");
                var bytes = Convert.FromBase64String(data);
                System.IO.File.WriteAllBytes($"wwwroot/images/{fileName}", bytes);

                var contato = new Contato
                {
                    Nome = model.Nome,
                    Endereco = model.Endereco,
                    Telefone = model.Telefone,
                    Email = model.Email,
                    Imagem = $"images/{fileName}"
                };

                await context.TabContato.AddAsync(contato);
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
