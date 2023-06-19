using InventoryManager.Core.OutputPorts;
using InventoryManager.Infra.Data.Repositories;

namespace InventoryManager.Presentation.Extensions
{
    public static class InfraDataExtensions
    {
        public static IServiceCollection AddInfraDataMerchandiseRepository(this IServiceCollection service) 
        {
            service.AddScoped<IMerchandiseRepository, MerchandiseRepository>();
            service.AddScoped<ITransactionRepository, TransactionRepository>();

            return service;
        }
    }
}
