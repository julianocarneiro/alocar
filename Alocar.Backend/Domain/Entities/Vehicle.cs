using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }
        public string ManufactureModel { get; set; }
        public string ManufactureYear { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Allocation> Allocations { get; set; }
        

    }
}


/*
 
 CREATE TABLE Vehicles (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Brand VARCHAR(100),
    ManufactureModel VARCHAR(4),
    ManufactureYear VARCHAR(4),
    Color VARCHAR(20),
    Plate VARCHAR(20) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);
 
 */