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
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
    
        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDTO>> GetAll()
        {
            var clients = await _clientRepository.GetAll();
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }

        public async Task<ClientDTO> GetById(int Id)
        {
            var client = await _clientRepository.GetById(Id);
            return _mapper.Map<ClientDTO>(client);
        }

        public async Task<ClientDTO> Create(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            client.CreatedAt = DateTime.Now;
            client.UpdatedAt = DateTime.Now;
            var clientCreated = await _clientRepository.Create(client);
            return _mapper.Map<ClientDTO>(clientCreated);
        }

        public async Task<ClientDTO> Update(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            client.UpdatedAt = DateTime.Now;
            var clientUpdated = await _clientRepository.Update(client);
            return _mapper.Map<ClientDTO>(clientUpdated);
        }

        public async Task<ClientDTO> Delete(int Id)
        {
            var clientDeleted = await _clientRepository.Delete(Id);
            return _mapper.Map<ClientDTO>(clientDeleted);
        }

    }
}
