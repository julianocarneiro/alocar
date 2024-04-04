using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities
{
    public class Allocation
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public int VehicleId { get; set; }
        public bool Finished { get; set; }
        public DateTime AllocationDate { get; set; }   
        public DateTime ReturnDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Client Client { get; set; }
        public Vehicle Vehicle { get; set; }

       
    }
}

/*

    FOREIGN KEY (ClientId) REFERENCES Clients(id),
    FOREIGN KEY (VehicleId) REFERENCES Vehicles(id)

 */