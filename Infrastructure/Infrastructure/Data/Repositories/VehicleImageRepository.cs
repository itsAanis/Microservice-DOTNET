using Microsoft.EntityFrameworkCore;
using Recreate.Infrastructure.Data.Abstractions;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Repositories
{
    public class VehicleImageRepository : GenericRepository<VehicleImage>, IVehicleImage
    {
        public VehicleImageRepository(RecreateDbContext dbContext) : base(dbContext)
        {


        }

        public async Task<VehicleImage> GetImagesByVehicleId(int vehicleId)
        {
           
            
            VehicleImage result = await _dbContext.Set<VehicleImage>().FirstOrDefaultAsync(v => v.VehicleId == vehicleId);

            return result;
        }

    }
}
