using Recreate.Infrastructure.Data.Abstractions;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Entities.Abstractions;
using Recreate.Infrastructure.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrand


    {
       
      public  BrandRepository (RecreateDbContext dbContext): base(dbContext) { 
        
        
        }



}
      
}
