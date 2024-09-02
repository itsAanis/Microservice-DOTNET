using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recreate.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.EntityTypeConfigurations
{
    public class VehicleImageConfiguration : IEntityTypeConfiguration<VehicleImage>
    {


        public  void Configure(EntityTypeBuilder<VehicleImage> builder)
        {
            builder.Property(e => e.ImageUrl).IsRequired().HasMaxLength(400);


        }
    }
}
