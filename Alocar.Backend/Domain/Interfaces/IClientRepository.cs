using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();

        Task<Client> GetById(int Id);

        Task<Client> Create(Client client);

        Task<Client> Update(Client client);

        Task<Client> Delete(int Id);

    }
}
