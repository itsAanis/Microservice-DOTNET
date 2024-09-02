using Recreate.Infrastructure.Data.Entities.Abstractions;

namespace Recreate.Infrastructure.Data.Entities
{
    public class Location : EntityBase
    {
        public string? Name { get; set; }

        public virtual ICollection<Vehicle>? Vehicles { get; set; }

        public virtual ICollection<Brand>? Brands { get; set; }

    }
}
