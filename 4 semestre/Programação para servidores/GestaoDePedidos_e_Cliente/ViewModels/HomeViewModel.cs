using System.ComponentModel.DataAnnotations;

namespace GestaoDePedidos_e_Cliente.ViewModels
{
    public class CreatePedidoViewModel
    {
        public int valorTotal { get; set; }
        [Required]
        public int[]? quantidadeProdutos { get; set; }

        [Required]
        public int idCliente { get; set; }
        [Required]
        public int[]? idProduto { get; set; }
    }

    public class CreateClienteViewModel
    {
        public string? nome { get; set; }
        public string? cpf { get; set; }
        public string? email { get; set; }
        public string? telefone { get; set; }
        public string? endereco { get; set; }
    }

    public class CreateProdutoViewModel
    {
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public int preco { get; set; }
        public int quantidadeEmEstoque { get; set; }
        public int codigoDoProduto { get; set; }
    }
}