using InventoryManager.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.OutputPorts
{
    public interface ITransactionRepository
    {
        Task<Transaction> CreateTransactionAsync(Transaction transaction);

        Task<Transaction> UpdateTransactionAsync(Transaction transaction);

        Task<Transaction> DeleteTransactionAsync(Transaction transaction);

        Task<IEnumerable<Transaction>> GetAllTransactions();

        Task<Transaction> GetTransactionById(Guid id);
    }
}