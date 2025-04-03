namespace GestaoDePedidos_e_Cliente.Models
{
    public class Pedido
    {
        public int valorTotal { get; set; }
        public required int[] quantidadeProdutos { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime finalizacao { get; set; }

        public int idCliente { get; set; }
        public int[]? idProdutos { get; set; }
    }
}