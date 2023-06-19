using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Presentation.Models
{
    public class MerchandiseRegisterViewModel
    {
        [Required(ErrorMessage = "Por favor, informe o número de registro.")]
        public Guid RegisterNumber { get; set; }

        [Required(ErrorMessage = "Preencha um nome.")]
        [MinLength(6, ErrorMessage = "Preencha um nome de no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Preencha um nome de no máximo {1} caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Preencha um fabricante.")]
        [MinLength(6, ErrorMessage = "Preencha um fabricante de no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Preencha um fabricante de no máximo {1} caracteres.")]
        public string? Manufacturer { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo da mercadoria.")]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Preencha uma descrição.")]
        [MinLength(10, ErrorMessage = "Preencha uma descrição de no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Preencha um fabricante de no máximo {1} caracteres.")]
        public string? Description { get; set; }
    }
}