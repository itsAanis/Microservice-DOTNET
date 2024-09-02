using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Entities.Enums
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum VehicleStatusEnum
        {
            reserved,
            sold,
            available,
            unassigned


        }


    
}
