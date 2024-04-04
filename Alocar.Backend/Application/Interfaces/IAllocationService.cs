using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAllocationService
    {
        Task<IEnumerable<AllocationDTO>> GetAll();
        Task<AllocationDTO> GetById(int Id);
        Task<AllocationDTO> Create(AllocationDTO allocationDTO);
        Task<AllocationDTO> Update(AllocationDTO allocationDTO);
        Task<AllocationDTO> Delete(int Id);
    }
}
