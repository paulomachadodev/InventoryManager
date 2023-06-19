using InventoryManager.Core.DomainEntities;
using InventoryManager.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.InputPorts
{
    public interface IMerchandiseService
    {
        Task<Merchandise> CreateMerchandiseAsync(MerchandiseRegisterDto dto);

        Task<Merchandise> UpdateMerchandiseAsync(MerchandiseRegisterDto dto);

        Task<Merchandise> DeleteMerchandiseAsync(Guid id);

        Task<IEnumerable<Merchandise>> GetAllMerchandises();

        Task<Merchandise> GetMerchandiseById(Guid id);
    }
}
