using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Livro
    {
        public int id {get; set;}
        public string? titulo {get; set;}
        public string? editora {get; set;}
        [Column("anoDePulbicacao")]
        public int anoDePublicacao {get; set;}
        public string? autor {get; set;}
        public int quantidadeEmEstoque {get; set;}
    }
}