using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class AllocationDTO
    {
        [IgnoreDataMember]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int VehicleId { get; set; }
        public bool Finished { get; set; }
        public DateTime AllocationDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
