using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Recreate.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recreate.Infrastructure.Data.Entities.Enums;

namespace Recreate.Infrastructure.Data.EntityTypeConfigurations
{
    internal class VehicleStatusConfiguration : IEntityTypeConfiguration<VehicleStatus>
    {
        public void Configure(EntityTypeBuilder<VehicleStatus> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.status).HasConversion(
                new EnumToStringConverter<VehicleStatusEnum>());



        }
    
    }
}
