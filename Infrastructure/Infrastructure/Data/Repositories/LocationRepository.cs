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
    internal class LocationRepository  :GenericRepository<Location>, ILocation
    {


        public LocationRepository(RecreateDbContext dbContext) : base(dbContext)
        {


        }


    }
}
