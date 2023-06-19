using InventoryManager.Core.DomainEntities;
using InventoryManager.Core.OutputPorts;
using InventoryManager.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Infra.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public async Task<Transaction> CreateTransactionAsync(Transaction transaction)
        {
            using (var context = new SqlServerContext())
            {
                context.Add(transaction);
                await context.SaveChangesAsync();
            }

            return transaction;
        }

        public async Task<Transaction> UpdateTransactionAsync(Transaction transaction)
        {
            using (var context = new SqlServerContext()) 
            { 
                context.Update(transaction);
                await context.SaveChangesAsync();
            }

            return transaction;
        }

        public async Task<Transaction> DeleteTransactionAsync(Transaction transaction)
        {
            using (var context = new SqlServerContext()) 
            { 
                context.Remove(transaction);
                await context.SaveChangesAsync();
            }

            return transaction;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            using (var context = new SqlServerContext()) 
            {
                return await context.Set<Transaction>().ToListAsync();
            }
        }

        public async Task<Transaction> GetTransactionById(Guid id)
        {
            using (var context = new SqlServerContext())
            {
                return await context.Set<Transaction>().FindAsync(id);
            }
        }
    }
}
