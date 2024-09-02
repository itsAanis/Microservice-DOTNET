using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Entities.Abstractions;
using Recreate.Infrastructure.Data.Repositories;
using Recreate.Infrastructure.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            services.AddScoped<IVehicle, VehicleRepository>();
            services.AddScoped<IBrand, BrandRepository>();
            services.AddScoped<ILocation, LocationRepository>();
            services.AddScoped<IVehicleImage, VehicleImageRepository>();
            services.AddScoped<IBrandLocation, BrandLocationRepository>();

            return services;
        }




    }
}
