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
    public class BrandLocationConfiguration : IEntityTypeConfiguration<BrandLocation>
    {
        public void Configure(EntityTypeBuilder<BrandLocation> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }


    }
}
