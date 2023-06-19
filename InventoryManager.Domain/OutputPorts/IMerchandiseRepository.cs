using InventoryManager.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.OutputPorts
{
    public interface IMerchandiseRepository
    {
        Task<Merchandise> CreateMerchandiseAsync(Merchandise merchandise);

        Task<Merchandise> UpdateMerchandiseAsync(Merchandise merchandise);

        Task<Merchandise> DeleteMerchandiseAsync(Merchandise merchandise);

        Task<IEnumerable<Merchandise>> GetAllMerchandises();

        Task<Merchandise> GetMerchandiseById(Guid id);
    }
}
