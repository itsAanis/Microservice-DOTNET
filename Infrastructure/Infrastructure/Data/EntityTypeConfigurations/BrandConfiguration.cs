using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recreate.Infrastructure.Data.Entities;

namespace Recreate.Infrastructure.Data.EntityTypeConfigurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
           
            
           

        }

    }
}
