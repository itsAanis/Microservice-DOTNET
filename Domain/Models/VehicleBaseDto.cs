using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class VehicleBaseDto
    {
        
        public int Id { get; set; }
        public string Model { get; set; }

        public string Make { get; set; }

        public decimal Price { get; set; }

        public decimal Mileage { get; set; }

        public int LocationId { get; set; }
    }
}
