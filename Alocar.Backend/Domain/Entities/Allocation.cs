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
        public int? Id { get; private set; }

        public int ClientId { get; private set; }
        public int VehicleId { get; private set; }
        public bool Finished { get; private set; }
        public DateTime AllocationDate { get; private set; }   
        public DateTime ReturnDate { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Client? Client { get; set; }
        public Vehicle? Vehicle { get; set; }

        public Allocation(int id, int clientId, int vehicleId, bool finished, 
            DateTime allocationDate, DateTime returnDate, 
            DateTime createdAt, DateTime updatedAt)
        {
            DomainExceptionValidation.When(id < 0, "O id deve ser maior que zero.");
            Id = id;
            ValidateDomain(clientId, vehicleId, finished, allocationDate, returnDate, createdAt, updatedAt);
        }

        public Allocation(int clientId, int vehicleId, bool finished, 
            DateTime allocationDate, DateTime returnDate, 
            DateTime createdAt, DateTime updatedAt)
        {
            ValidateDomain(clientId, vehicleId, finished, allocationDate, returnDate, createdAt, updatedAt);
        }        
        
        public void Update(int clientId, int vehicleId, bool finished, 
            DateTime allocationDate, DateTime returnDate, 
            DateTime createdAt, DateTime updatedAt)
        {
            ValidateDomain(clientId, vehicleId, finished, allocationDate, returnDate, createdAt, updatedAt);
        }

        public void ValidateDomain(int clientId, int vehicleId, bool finished,
            DateTime allocationDate, DateTime returnDate,
            DateTime createdAt, DateTime updatedAt)
        {

            DomainExceptionValidation.When(clientId <= 0, "Id do Cliente deve ser maior que zero");
            DomainExceptionValidation.When(vehicleId <= 0, "Id do Veiculo deve ser maior que zero");

            ClientId = clientId;
            VehicleId = vehicleId;
            Finished = finished;
            AllocationDate = allocationDate;
            ReturnDate = returnDate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}

/*

    FOREIGN KEY (ClientId) REFERENCES Clients(id),
    FOREIGN KEY (VehicleId) REFERENCES Vehicles(id)

 */