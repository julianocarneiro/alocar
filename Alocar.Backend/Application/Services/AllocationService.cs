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
    public  class AllocationService : IAllocationService
    {
        private readonly IAllocationRepository _AllocationRepository;
        private readonly IMapper _mapper;

        public AllocationService(IAllocationRepository AllocationRepository, IMapper mapper)
        {
            _AllocationRepository = AllocationRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllocationDTO>> GetAll()
        {
            var Allocations = await _AllocationRepository.GetAll();
            return _mapper.Map<IEnumerable<AllocationDTO>>(Allocations);
        }

        public async Task<AllocationDTO> GetById(int Id)
        {
            var Allocation = await _AllocationRepository.GetById(Id);
            return _mapper.Map<AllocationDTO>(Allocation);
        }

        public async Task<AllocationDTO> Create(AllocationDTO AllocationDTO)
        {
            var Allocation = _mapper.Map<Allocation>(AllocationDTO);
            Allocation.CreatedAt = DateTime.Now;
            Allocation.UpdatedAt = DateTime.Now;
            var AllocationCreated = await _AllocationRepository.Create(Allocation);
            return _mapper.Map<AllocationDTO>(AllocationCreated);
        }

        public async Task<AllocationDTO> Update(AllocationDTO AllocationDTO)
        {
            var Allocation = _mapper.Map<Allocation>(AllocationDTO);
            Allocation.UpdatedAt = DateTime.Now;
            var AllocationUpdated = await _AllocationRepository.Update(Allocation);
            return _mapper.Map<AllocationDTO>(AllocationUpdated);
        }

        public async Task<AllocationDTO> Delete(int Id)
        {
            var AllocationDeleted = await _AllocationRepository.Delete(Id);
            return _mapper.Map<AllocationDTO>(AllocationDeleted);
        }
    }
}
