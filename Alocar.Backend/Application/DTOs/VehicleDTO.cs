﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public  class VehicleDTO
    {
        [IgnoreDataMember]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }
        public string ManufactureModel { get; set; }
        public string ManufactureYear { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }
    }
}
