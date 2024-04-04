using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _VehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository VehicleRepository, IMapper mapper)
        {
            _VehicleRepository = VehicleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDTO>> GetAll()
        {
            var Vehicles = await _VehicleRepository.GetAll();
            return _mapper.Map<IEnumerable<VehicleDTO>>(Vehicles);
        }

        public async Task<VehicleDTO> GetById(int Id)
        {
            var Vehicle = await _VehicleRepository.GetById(Id);
            return _mapper.Map<VehicleDTO>(Vehicle);
        }

        public async Task<VehicleDTO> Create(VehicleDTO VehicleDTO)
        {
            var Vehicle = _mapper.Map<Vehicle>(VehicleDTO);
            Vehicle.CreatedAt = DateTime.Now;
            Vehicle.UpdatedAt = DateTime.Now;
            var VehicleCreated = await _VehicleRepository.Create(Vehicle);
            return _mapper.Map<VehicleDTO>(VehicleCreated);
        }

        public async Task<VehicleDTO> Update(VehicleDTO VehicleDTO)
        {
            var Vehicle = _mapper.Map<Vehicle>(VehicleDTO);
            Vehicle.UpdatedAt = DateTime.Now;
            var VehicleUpdated = await _VehicleRepository.Update(Vehicle);
            return _mapper.Map<VehicleDTO>(VehicleUpdated);
        }

        public async Task<VehicleDTO> Delete(int Id)
        {
            var VehicleDeleted = await _VehicleRepository.Delete(Id);
            return _mapper.Map<VehicleDTO>(VehicleDeleted);
        }
    }
}
