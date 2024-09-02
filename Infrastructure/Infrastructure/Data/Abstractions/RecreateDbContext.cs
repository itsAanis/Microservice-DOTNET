using Microsoft.EntityFrameworkCore;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.EntityTypeConfigurations;
using static System.Net.Mime.MediaTypeNames;

namespace Recreate.Infrastructure.Data.Abstractions
{
    public class RecreateDbContext : DbContext 
    {
        public RecreateDbContext(IServiceProvider serviceProvider, DbContextOptions<RecreateDbContext> options)
             : base(options)
        {
        }

        public RecreateDbContext(DbContextOptions<RecreateDbContext> options)
          : base(options)
        {
        }


        // DbSet here 
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        // refers to the corresponding table name what comes after gives it the name ? 
        public virtual DbSet<Brand> Brands { get; set; }

        public virtual DbSet<BrandLocation> BrandLocations  { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        public virtual DbSet<VehicleStatus> VehicleStatuses { get; set; }

        public virtual DbSet<VehicleImage> VehicleImages { get; set; }

        // public DbSet<BrandLocation> BrandLocation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// method that is called when context being created , overrding to provide config

              modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleImageConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleStatusConfiguration());


            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Locations)
                .WithMany(e => e.Brands)
                .UsingEntity<BrandLocation>();



            modelBuilder.Entity<VehicleStatus>()
                .HasIndex(e => e.VehicleId)
                .IsUnique();
        



        /*

        modelBuilder.Entity<Vehicle>()
             .HasOne(v => v.Location) // has property called location
             .WithMany(c => c.Vehicles); // has many vehicles 


        modelBuilder.Entity<Vehicle>()
             .HasOne(v => v.Location) // has property called location
             .WithMany(c => c.Vehicles);

        */
    }

        }
}
