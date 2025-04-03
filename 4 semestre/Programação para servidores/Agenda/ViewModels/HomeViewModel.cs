using System.ComponentModel.DataAnnotations;

namespace Agenda.ViewModels
{
    public class CreateContatoViewModel
    {
        [Required(ErrorMessage = "Código é obrigatório!")]
        public string? nomeCompleto { get; set; }
        
        [Required(ErrorMessage = "Código é obrigatório!")]
        [MaxLength(11)]
        public string? Telefone { get; set; }
        
        [Required(ErrorMessage = "Código é obrigatório!")]
        public DateTime dataDeNascimento { get; set; }
    }
    
        public class UpdateContatoViewModel
    {
        [Required(ErrorMessage = "Código é obrigatório!")]
        public string? nomeCompleto { get; set; }

        [Required(ErrorMessage = "Código é obrigatório!")]
        [MaxLength(11)]
        public string? telefone { get; set; }

        [Required(ErrorMessage = "Código é obrigatório!")]
        public DateTime dataDeNascimento { get; set; }
    }
}