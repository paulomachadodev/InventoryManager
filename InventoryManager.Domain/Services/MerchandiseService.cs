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
    public class MerchandiseService : IMerchandiseService
    {
        private readonly IMerchandiseRepository _merchandiseRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TransactionService> _logger;

        public MerchandiseService(IMerchandiseRepository merchandiseRepository, IMapper mapper, ILogger<TransactionService> logger)
        {
            _merchandiseRepository = merchandiseRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Merchandise> CreateMerchandiseAsync(MerchandiseRegisterDto dto)
        {
            try
            {
                var merchandise = _mapper.Map<Merchandise>(dto);

                return await _merchandiseRepository.CreateMerchandiseAsync(merchandise);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An exception occurred while creating a new merchandise");
                throw;
            }

        }

        public async Task<Merchandise> DeleteMerchandiseAsync(Guid id)
        {
            try
            {
                var merchandise = _mapper.Map<Merchandise>(id);

                if (merchandise != null)
                {
                    await _merchandiseRepository.DeleteMerchandiseAsync(merchandise);
                    return merchandise;
                }

                _logger.LogWarning($"No transaction was found with the provided id: {id}");
                return merchandise;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An exception occurred while removing transaction with id: {id}");
                throw;
            }
        }

        public async Task<IEnumerable<Merchandise>> GetAllMerchandises()
        {
            try
            {
                return await _merchandiseRepository.GetAllMerchandises();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An exception occurred while getting all merchandises.");
                throw;
            }
        }

        public async Task<Merchandise> GetMerchandiseById(Guid id)
        {
            try
            {
                return await _merchandiseRepository.GetMerchandiseById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An exception occurred while getting a merchandise by id {id}");
                throw;
            }
        }

        public async Task<Merchandise> UpdateMerchandiseAsync(MerchandiseRegisterDto dto)
        {
            var merchandise = _mapper.Map<Merchandise>(dto);

            return await _merchandiseRepository.UpdateMerchandiseAsync(merchandise);
        }
    }
}
