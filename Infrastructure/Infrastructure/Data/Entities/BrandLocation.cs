using Recreate.Infrastructure.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Entities
{
    public class BrandLocation : EntityBase
    {

        public int BrandId { get; set; }
        public int LocationId { get; set; }
    }
}
