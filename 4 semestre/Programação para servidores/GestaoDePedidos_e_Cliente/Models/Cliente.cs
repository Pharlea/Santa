namespace GestaoDePedidos_e_Cliente.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? cpf { get; set; }
        public string? eMail { get; set; }
        public string? telefone { get; set; }
        public string? endereco { get; set; }
    }
}