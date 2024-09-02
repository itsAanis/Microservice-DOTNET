using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recreate.Infrastructure.Data.Entities;
using System.Linq.Expressions;

namespace Recreate.Infrastructure.Data.EntityTypeConfigurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public virtual void Configure(EntityTypeBuilder<Location> builder)
        {

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(250);

        }
      

    }
}
