using Recreate.Infrastructure.Data.Entities.Abstractions;

namespace Recreate.Infrastructure.Data.Entities
{
    public class Brand : EntityBase
    {
        public string? Name { get; set; }
        
        public virtual  ICollection <Location>? Locations { get; set; } // ?

    }
}
