using InventoryManager.Core.InputPorts;
using InventoryManager.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Core.Extensions
{
    public static class CoreExtensions
    {
        public static IServiceCollection AddCoreClientService(this IServiceCollection service)
        {
            service.AddScoped<IMerchandiseService, MerchandiseService>();
            service.AddScoped<ITransactionService, TransactionService>();

            return service;
        }
    }
}

