using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.DTOs
{
    public class MerchandiseRegisterDto
    {
        [Required(ErrorMessage = "Por favor, informe o nome da mercadoria.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Por favor, informe o número de registro.")]
        public int? RegisterNumber { get; set; }

        [Required(ErrorMessage = "Por favor, informe o fabricante.")]
        public string? Manufacturer { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo da mercadoria.")]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Por favor, informe a descrição da mercadoria.")]
        public string? Description { get; set; }
    }
}
