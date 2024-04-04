using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAll();
        Task<ClientDTO> GetById(int Id);
        Task<ClientDTO> Create(ClientDTO clientDTO);
        Task<ClientDTO> Update(ClientDTO clientDTO);
        Task<ClientDTO> Delete(int Id);
    }
}
