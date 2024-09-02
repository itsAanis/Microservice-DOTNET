using Domain.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BrandDto : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
}
