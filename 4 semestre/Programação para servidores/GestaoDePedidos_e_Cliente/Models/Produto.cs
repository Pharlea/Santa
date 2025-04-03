namespace GestaoDePedidos_e_Cliente.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public int preco { get; set; }
        public int quantidadeEmEstoque { get; set; }
        public int codigoDoProduto { get; set; }
    }
}