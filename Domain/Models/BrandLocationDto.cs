﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BrandLocationDto
    {
       public int BrandId { get; set; } 

        public int LocationId { get; set; }

        public string LocationName { get; set; }
        public string BrandName { get; set; }


    }
}
