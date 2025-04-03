using System.ComponentModel.DataAnnotations;

namespace MinhaLoja.ViewModel
{
    public class CategoryCreateViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}