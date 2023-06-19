using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.DomainEntities.Abstractions
{
    public abstract class EntityBase
    {
        public EntityBase() 
        { 
            Id = Guid.NewGuid();
            CreatedAt = DateTimeOffset.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? SetNewUpdatedAt()
        {
            UpdatedAt = DateTimeOffset.UtcNow;
            return UpdatedAt;
        }
    }
}
