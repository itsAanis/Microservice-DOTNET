using FCommon.Queries.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCommon.Queries.DependencyInjection
{
    internal static class ServiceCollectionExtensions
    {

        public static IServiceCollection addServices (this IServiceCollection services, IConfiguration configuration)
        {

            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<IVehicleQueries, VehicleService>();
            services.AddScoped<BrandService>();
            services.AddScoped<LocationService>();
            services.AddScoped<VehicleImageService>();
            services.AddScoped<BrandLocationService>();

            return services;
        }


        
    }
}
