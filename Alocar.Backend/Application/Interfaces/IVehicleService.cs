using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDTO>> GetAll();
        Task<VehicleDTO> GetById(int Id);
        Task<VehicleDTO> Create(VehicleDTO vehicleDTO);
        Task<VehicleDTO> Update(VehicleDTO vehicleDTO);
        Task<VehicleDTO> Delete(int Id);
    }
}
