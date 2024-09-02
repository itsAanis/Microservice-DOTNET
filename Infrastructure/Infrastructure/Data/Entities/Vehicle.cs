using Recreate.Infrastructure.Data.Entities.Abstractions;
using Recreate.Infrastructure.Data.Entities.Enums;

namespace Recreate.Infrastructure.Data.Entities
{
    public class Vehicle : EntityBase
    {

        public string? Make { get; set; }
        public string? Model { get; set; }

        public decimal Price { get; set; }

        public int Mileage { get; set; }


        public int? LocationId { get; set; }

        public virtual Location? Location { get; set; }

        public virtual ICollection<VehicleImage>? Images { get; set; }

        // vehicle images 
       
    }
}
