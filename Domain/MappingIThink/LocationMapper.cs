using Domain.Models;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MappingIThink
{
    public class LocationMapper
    {
        public static LocationDto toDto(Location location)
        {

            return new LocationDto
            {
                Id = location.Id,
        //        LocationName = location.LocationName

            };

        }

        public static Location ToEntity(LocationDto dto)
        {
            return new Location
            {
                Id = dto.Id,
            //    LocationName = dto.LocationName

            };
        }



    }
}
