using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recreate.Infrastructure.Data.Abstractions;
using Recreate.Infrastructure.Data.DependencyInjection;
namespace Recreate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public IConfiguration Configuration { get; }
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }


            

        //    services.AddDbContext<RecreateDbContext>(options => options.UseSqlServer(ConnectionStrings));

            services.AddServices(configuration);
            
        }


        }
}
