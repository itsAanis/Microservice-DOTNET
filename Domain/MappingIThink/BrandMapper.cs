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
    public class BrandMapper
    {
        public static BrandDto toDto(Brand brand)
        {

            return new BrandDto
            {
                Id = brand.Id,
                Name = brand.Name,
        //        Description = brand.Description,
            };

        }

        public static Brand ToEntity(BrandDto dto)
        {
            return new Brand
            {
                Id = dto.Id,
                Name = dto.Name,
         //       Description = dto.Description
            };
        }




    }
}
