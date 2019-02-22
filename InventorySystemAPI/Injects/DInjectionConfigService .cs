using InventorySystemAPI.Entity;
using InventorySystemAPI.Interfaces;
using InventorySystemAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Injects
{
    public static class DInjectionConfigService
    {
        public static IServiceCollection RegisterDInjection(this IServiceCollection services)
        {
            services.AddTransient<IAttributeValues, AttributeValues>();
            services.AddTransient<IAttributesRepository, AttributesRepository>();
            services.AddTransient<StockContext>();
            return services;
        }
    }
}
