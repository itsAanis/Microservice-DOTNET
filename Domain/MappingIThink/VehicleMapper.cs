using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Repositories.Abstraction;

namespace Domain.MappingIThink
{
    public  class VehicleMapper
    {

        public static VehicleBaseDto toDto (Vehicle vehicle) {

            return new VehicleBaseDto
            {   Id = vehicle.Id,
                Model = vehicle.Model,
                LocationId = (int)vehicle.LocationId,
                Price = vehicle.Price,
                Mileage = vehicle.Mileage,
                Make = vehicle.Make
            };
        
        }

        public static Vehicle ToEntity(VehicleBaseDto dto)
        {
            return new Vehicle
            {
                Id = dto.Id,
                Model = dto.Model,
                LocationId = dto.LocationId,
                Price = dto.Price,
                Mileage = (int)dto.Mileage,
                Make = dto.Make
            };
        }




    }
}
