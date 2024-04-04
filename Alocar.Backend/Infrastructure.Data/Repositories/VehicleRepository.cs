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
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;

        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            var vehicle = await _context.Vehicles.ToListAsync();
            return vehicle;

        }

        public async Task<Vehicle> GetById(int Id)
        {
            var vehicle = await _context.Vehicles.Where(c => c.Id == Id).FirstOrDefaultAsync();
            return vehicle;
        }

        public async Task<Vehicle> Create(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }
        public async Task<Vehicle> Update(Vehicle vehicle)
        {
            _context.Vehicles.Update(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle> Delete(int Id)
        {
            var vehicle = await _context.Vehicles.FindAsync(Id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
                await _context.SaveChangesAsync();
                return vehicle;
            }

            return null;

        }
    }
}
