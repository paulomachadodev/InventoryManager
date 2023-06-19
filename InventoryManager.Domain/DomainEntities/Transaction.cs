using InventoryManager.Core.DomainEntities.Abstractions;
using InventoryManager.Core.DomainEntities.Enums;
using InventoryManager.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.DomainEntities
{
    public class Transaction : EntityBase
    {
        public Transaction()
        {
            DateTime = DateTime.Now;
        }

        public Guid? Id { get; private set; }
        public int? Quantity { get; set; }
        public DateTime DateTime { get; private set; }
        public string? Local { get; set; }
        public Guid? MerchandiseId { get; set; }
        public TransactionType? TransactionType { get; set; }

        public Merchandise? Merchandise { get; set; }
    }
}
