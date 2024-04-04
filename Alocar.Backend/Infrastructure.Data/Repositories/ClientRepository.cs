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
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Client>> GetAll()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
            
        }

        public async Task<Client> GetById(int Id)
        {
            var client = await _context.Clients.Where(c => c.Id == Id).FirstOrDefaultAsync();
            return client;            
        }

        public async Task<Client> Create(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }
        public async Task<Client> Update(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> Delete(int Id)
        {
            var client = await _context.Clients.FindAsync(Id);
            if (client != null)
            {                
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
                return client;
            }

            return null;
            
        }
    }
}
