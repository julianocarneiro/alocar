using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAll();

        Task<Vehicle> GetById(int Id);

        Task<Vehicle> Create(Vehicle vehicle);

        Task<Vehicle> Update(Vehicle vehicle);

        Task<Vehicle> Delete(int Id);
    }
}
