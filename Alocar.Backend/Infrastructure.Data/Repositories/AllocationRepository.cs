using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class AllocationRepository : IAllocationRepository
    {
        private readonly ApplicationDbContext _context;

        public AllocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Allocation>> GetAll()
        {
            var allocations = await _context.Allocations.ToListAsync();
            return allocations;

        }

        public async Task<Allocation> GetById(int Id)
        {
            var allocation = await _context.Allocations.Where(c => c.Id == Id).FirstOrDefaultAsync();
            return allocation;
        }

        public async Task<Allocation> Create(Allocation allocation)
        {
            _context.Allocations.Add(allocation);
            await _context.SaveChangesAsync();
            return allocation;
        }
        public async Task<Allocation> Update(Allocation allocation)
        {
            _context.Allocations.Update(allocation);
            await _context.SaveChangesAsync();
            return allocation;
        }

        public async Task<Allocation> Delete(int Id)
        {
            var allocation = await _context.Allocations.FindAsync(Id);
            if (allocation != null)
            {
                _context.Allocations.Remove(allocation);
                await _context.SaveChangesAsync();
                return allocation;
            }

            return null;

        }


    }
}
