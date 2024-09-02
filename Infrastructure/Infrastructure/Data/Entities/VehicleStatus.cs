using Recreate.Infrastructure.Data.Entities.Abstractions;
using Recreate.Infrastructure.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Entities
{
    public class VehicleStatus : EntityBase
    {
      public   int VehicleId { get; set; }

        public VehicleStatusEnum status { get; set; }

        public virtual Vehicle? Vehicle { get; set; }


    }
}
