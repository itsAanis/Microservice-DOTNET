using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Entities.Enums;
using Microsoft.EntityFrameworkCore;


namespace Recreate.Infrastructure.Data.EntityTypeConfigurations
{
    public  class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public virtual void Configure(EntityTypeBuilder<Vehicle> builder)
        {// from EF configure properties , relationship , keys etc 
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Created).ValueGeneratedOnAdd().HasDefaultValueSql("GETUTCDATE()");
           builder.Property(e => e.Modified).ValueGeneratedOnAdd().HasDefaultValueSql("GETUTCDATE()");
            builder.Property(b => b.Model).HasMaxLength(250);
            builder.Property(b => b.Price).HasColumnType("DECIMAL");
       //     builder.Property(b => b.Mileage).
            //     builder.Property(b => b.VehicleType).HasMaxLength(50);
            builder.Property(v => v.LocationId).ValueGeneratedOnAdd();




           
           

        }


        }
}
