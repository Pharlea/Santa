using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controller
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("/")] //inserir os dados
        public IActionResult postDados ([FromServices]AppDbContext context, [FromBody]Livro umLivro)
        {
            context.tbLivros?.Add(umLivro);
            context.SaveChanges();

            return Created($"/{umLivro.id}", umLivro);
        }

        [HttpPut("/{id:int}")] //editar os dados
        public IActionResult putDados([FromServices]AppDbContext context, Livro umLivro, [FromRoute]int id)
        {
            var livroExistente = context.tbLivros?.Find(id);

            if (livroExistente is null) {return NotFound();}

            livroExistente.titulo = umLivro.titulo;
            livroExistente.autor = umLivro.autor;
            livroExistente.anoDePublicacao = umLivro.anoDePublicacao;
            livroExistente.editora = umLivro.editora;
            livroExistente.quantidadeEmEstoque = umLivro.quantidadeEmEstoque;

            context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("/{id:int}")]
        public IActionResult removeDados([FromServices]AppDbContext context, [FromRoute]int id)
        {
            var livroExistente = context.tbLivros?.Find(id);

            if (livroExistente is null) {return NotFound();}

            context.tbLivros?.Remove(livroExistente);
            context.SaveChanges();

            return NoContent();
        }

        [HttpGet("/{id:int}")]
        public IActionResult getDadosId ([FromServices]AppDbContext context, [FromRoute]int id)
        {
            var livroExistente = context.tbLivros?.Find(id);

            if (livroExistente is null) {return NotFound();}

            return Ok(livroExistente);
        }

        [HttpGet("/")]
        public IActionResult getDados ([FromServices]AppDbContext context)
        {
            var todosLivros = context.tbLivros?.ToList();
            return Ok(todosLivros);
        }

        [HttpPatch("/adicionar-estoque/{id:int}/{qnt:int}")]
        public IActionResult adicionarEstoque ([FromServices]AppDbContext context, [FromRoute]int id, [FromRoute]int qnt)
        {
            var livroExistente = context.tbLivros?.Find(id);
            if (livroExistente is null) {return NotFound();}

            livroExistente.quantidadeEmEstoque += qnt;
            context.SaveChanges();
            
            return NoContent();
        }

        [HttpPatch("/remover-estoque/{id:int}/{qnt:int}")]
        public IActionResult removerEstoque ([FromServices]AppDbContext context, [FromRoute]int id, [FromRoute]int qnt)
        {
            var livroExistente = context.tbLivros?.Find(id);
            if (livroExistente is null) {return NotFound();}

            livroExistente.quantidadeEmEstoque -= qnt;
            context.SaveChanges();
            
            return NoContent();
        }

        [HttpGet("/{editora:alpha}")]
        public IActionResult getDadosEditora([FromServices] AppDbContext context, [FromRoute]string editora)
        {
            var todosLivrosEditora = context.tbLivros?.Where(x => x.editora == editora).ToList();

            if (todosLivrosEditora is null) {return NotFound();}

            return Ok(todosLivrosEditora);
        }
    }
}