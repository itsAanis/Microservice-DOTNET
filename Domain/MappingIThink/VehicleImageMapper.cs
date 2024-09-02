using Domain.Models;
using Recreate.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MappingIThink
{
    public class VehicleImageMapper
    {

        public static VehicleImageDto toDto(VehicleImage vehicle)
        {
           
            return new VehicleImageDto
            {
                VehicleId = vehicle.VehicleId,
                ImageUrl = vehicle.ImageUrl,
            };


        }
    }
}
