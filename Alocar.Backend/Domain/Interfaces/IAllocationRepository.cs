using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAllocationRepository
    {
        Task<IEnumerable<Allocation>> GetAll();

        Task<Allocation> GetById(int Id);

        Task<Allocation> Create(Allocation allocation);

        Task<Allocation> Update(Allocation allocation);

        Task<Allocation> Delete(int Id);
    }
}
