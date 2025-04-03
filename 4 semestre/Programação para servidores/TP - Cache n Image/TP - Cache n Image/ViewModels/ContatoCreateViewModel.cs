using System.ComponentModel.DataAnnotations;

namespace TP___Cache_n_Image.ViewModels
{
    public class ContatoCreateViewModel
    {
        [Required]
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
    }
}
