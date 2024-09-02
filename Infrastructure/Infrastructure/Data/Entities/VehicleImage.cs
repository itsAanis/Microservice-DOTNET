using Recreate.Infrastructure.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Entities
{
    public class VehicleImage : EntityBase
    {

        public string? ImageUrl
        { get; set; }
        public int VehicleId { get; set;}

        public virtual Vehicle? Vehicle { get; set; }

    
    }
}
