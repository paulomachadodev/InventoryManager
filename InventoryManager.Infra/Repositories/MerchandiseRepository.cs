using InventoryManager.Core.OutputPorts;
using InventoryManager.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Infra.Data.Repositories
{
    public class MerchandiseRepository : IMerchandiseRepository
    {
        public async Task<Merchandise> CreateMerchandiseAsync(Merchandise merchandise)
        {
            using(var context = new SqlServerContext())
            {
                context.Add(merchandise);
                await context.SaveChangesAsync();
            }

            return merchandise;
        }

        public async Task<Merchandise> UpdateMerchandiseAsync(Merchandise merchandise)
        {
            using (var context = new SqlServerContext())
            {
                context.Update(merchandise);
                await context.SaveChangesAsync();
            }

            return merchandise;
        }

        public async Task<Merchandise> DeleteMerchandiseAsync(Merchandise merchandise)
        {
            using (var context = new SqlServerContext())
            {
                context.Remove(merchandise);
                await context.SaveChangesAsync();
            }

            return merchandise;
        }

        public async Task<IEnumerable<Merchandise>> GetAllMerchandises()
        {
            using (var context = new SqlServerContext())
            {
                return await context.Set<Merchandise>().ToListAsync();
            }
        }

        public async Task<Merchandise>? GetMerchandiseById(Guid id)
        {
            using (var context = new SqlServerContext())
            {
                return await context.Set<Merchandise>().FindAsync(id);
            }
        }
    }
}
