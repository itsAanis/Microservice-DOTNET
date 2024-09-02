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
    public class BrandLocationRepository : GenericRepository<BrandLocation>, IBrandLocation
    {

        public BrandLocationRepository(RecreateDbContext dbContext) : base(dbContext) {


        }



        public async Task<List<Tuple<int, string, int, string>>> GetAllBrandLocation()
        {
            var AllbrandLocation = await (from brand in _dbContext.Brands
                                          //brand loop inside table
                                          join brandLocation in _dbContext.BrandLocations on brand.Id equals brandLocation.BrandId
                                          // join the table where they both have brand id
                                          join location in _dbContext.Locations on brandLocation.LocationId equals location.Id
                                          // same with location
                                          // and then add them to table 
                                          select Tuple.Create(brand.Id, brand.Name, location.Id, location.Name)).ToListAsync();

            return AllbrandLocation;



   
    }
    }

}
