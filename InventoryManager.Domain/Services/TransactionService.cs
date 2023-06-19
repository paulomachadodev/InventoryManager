using AutoMapper;
using InventoryManager.Core.DomainEntities;
using InventoryManager.Core.DTOs;
using InventoryManager.Core.InputPorts;
using InventoryManager.Core.OutputPorts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ILogger<TransactionService> _logger;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository transactionRepository, ILogger<TransactionService> logger, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Transaction> CreateTransactionAsync(TransactionRegisterDto dto)
        {
            try
            {
                var transaction = _mapper.Map<Transaction>(dto);

                return await _transactionRepository.CreateTransactionAsync(transaction);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An exception occurred while creating a new transaction");
                throw;
            }
        }

        public async Task<Transaction> DeleteTransactionAsync(Guid id)
        {
            try
            {
                var transaction = await _transactionRepository.GetTransactionById(id);

                if (transaction != null)
                {
                    await _transactionRepository.DeleteTransactionAsync(transaction);
                    return transaction;
                }

                _logger.LogWarning($"No transaction was found with the provided id: {id}");
                return transaction;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An exception occurred while removing transaction with id: {id}");
                throw;
            }
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            try
            {
                return await _transactionRepository.GetAllTransactions();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An exception occurred while getting all transactions.");
                throw;
            }
        }

        public async Task<Transaction> GetTransactionById(Guid id)
        {
            try
            {
                return await _transactionRepository.GetTransactionById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An exception occurred while getting a transaction by id {id}");
                throw;
            }
        }

        public async Task<Transaction> UpdateTransactionAsync(TransactionRegisterDto dto)
        {
            try
            {
                var transaction = _mapper.Map<Transaction>(dto);
                var existingTransaction = await _transactionRepository.GetTransactionById(dto.Id);

                if (existingTransaction != null)
                    await _transactionRepository.UpdateTransactionAsync(transaction);

                    return transaction;
            }
            catch (Exception e) 
            { 
                _logger.LogError(e, $"An exception occurred while updating transaction with id: {dto.Id}");
                throw;
            }
        }
    }
}
