using InventoryManager.Core.DomainEntities;
using InventoryManager.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.InputPorts
{
    public interface ITransactionService
    {
        Task<Transaction> CreateTransactionAsync(TransactionRegisterDto dto);

        Task<Transaction> UpdateTransactionAsync(TransactionRegisterDto dto);

        Task<Transaction> DeleteTransactionAsync(Guid id);

        Task<IEnumerable<Transaction>> GetAllTransactions();

        Task<Transaction> GetTransactionById(Guid id);
    }
}
