using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using GestaoDePedidos_e_Cliente.Data;
using GestaoDePedidos_e_Cliente.Models;
using GestaoDePedidos_e_Cliente.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDePedidos_e_Cliente.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("/cliente")]
        public async Task<IActionResult> PostAsync([FromBody] CreateClienteViewModel umCliente, [FromServices]AppDbContext context)
        {            
            var novoCliente = new Cliente
            {
                nome = umCliente.nome,
                cpf = umCliente.cpf,
                eMail = umCliente.email,
                telefone = umCliente.telefone,
                endereco = umCliente.endereco
            };

            if (Regex.IsMatch(novoCliente.cpf, "^[0-9]{11}$")) {return BadRequest();}
            if (Regex.IsMatch(novoCliente.eMail, "[]+@gmail.com$")) {return BadRequest();}
            if (context.tbClientes.Find(novoCliente.id) is not null) { return BadRequest(); }
            
            await context.tbClientes.AddAsync(novoCliente);
            await context.SaveChangesAsync();
            
            return Created($"/{novoCliente.id}", novoCliente);
        }

        [HttpPost("/produto")]
        public async Task<IActionResult> PostAsync([FromBody] CreateProdutoViewModel umProduto, [FromServices]AppDbContext context)
        {
            var novoProduto = new Produto
            {
                nome = umProduto.nome,
                descricao = umProduto.descricao,
                preco = umProduto.preco,
                quantidadeEmEstoque = umProduto.quantidadeEmEstoque,
                codigoDoProduto = umProduto.codigoDoProduto
            };
            if (context.tbProdutos.Find(novoProduto.id) is not null) { return BadRequest(); }

            await context.tbProdutos.AddAsync(novoProduto);
            await context.SaveChangesAsync();
            
            return Created($"/{novoProduto.id}", novoProduto);
        }

        [HttpPost("/pedido")]
        public async Task<IActionResult> PostAsync([FromBody] CreatePedidoViewModel umPedido, [FromServices]AppDbContext context)
        {
            int valorTotal = 0;
            DateTime inicio = DateTime.Now;
            for (int i = 0; i < umPedido.quantidadeProdutos.Length; i++)
            {
                var umProduto = context.tbProdutos.Find(umPedido.idProduto[i]);

                if (umProduto is null) { return NotFound(umPedido.idProduto[i]); }
                if (umPedido.quantidadeProdutos[i] > umProduto.quantidadeEmEstoque) { return BadRequest(); }

                for (int x = 0; x < umPedido.quantidadeProdutos[i]; x++)
                {
                    valorTotal += umProduto.preco;
                } 
            }

            var novoPedido = new Pedido
            {
                valorTotal = umPedido.valorTotal,
                quantidadeProdutos = umPedido.quantidadeProdutos,
                idCliente = umPedido.idCliente,
                idProdutos = umPedido.idProduto,
                dataCriacao = inicio,
                finalizacao = DateTime.Now
            };

            
            await context.tbPedidos.AddAsync(novoPedido);
            await context.SaveChangesAsync();

            
            for (int i = 0; i < umPedido.quantidadeProdutos.Length; i++)
            {
                var umProduto = context.tbProdutos.Find(umPedido.idProduto[i]);

                umProduto.quantidadeEmEstoque -= umPedido.quantidadeProdutos[i];
                await context.SaveChangesAsync();
            }
            umPedido.valorTotal = valorTotal;

            return Created($"/{umPedido}", novoPedido);
        }

        [HttpGet("/cliente/{id:int}")]
        public IActionResult GetById([FromRoute] int id, [FromServices]AppDbContext context)
        {
             var umCliente = context.tbClientes.Find(id);
            if (context.tbClientes.Find(id) is null) {return NotFound();}
            var umPedido = context.tbPedidos.ToList<Pedido>.Find(id);

        }
    }
}