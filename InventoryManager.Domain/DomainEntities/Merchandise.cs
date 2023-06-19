using InventoryManager.Core.DomainEntities;
using InventoryManager.Core.DomainEntities.Abstractions;
using InventoryManager.Core.DomainEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.DomainEntities;

public class Merchandise : EntityBase
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int? RegisterNumber { get; set; }
    public string? Manufacturer { get; set; }
    public string? Type { get; set; }
    public string? Description { get; set; }

    public List<Transaction>? Transactions { get; set; }
}
