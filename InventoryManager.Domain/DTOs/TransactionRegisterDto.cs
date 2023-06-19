using InventoryManager.Core.DomainEntities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.DTOs
{
    public class TransactionRegisterDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Por favor, informe a quantidade.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data e hora.")]
        public DateTime? DateTime { get; set; }

        [Required(ErrorMessage = "Por favor, informe o local.")]
        public string? Local { get; set; }

        [Required(ErrorMessage = "Por favor, selecione a mercadoria.")]
        public Guid? MerchandiseId { get; set; }

        [Required(ErrorMessage = "Por favor, selecione o tipo.")]
        public TransactionType? Tipo { get; set; }
    }
}
