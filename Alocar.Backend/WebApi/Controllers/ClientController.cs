using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {

        private readonly IClientService _clientService;
        
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientsDTO = await _clientService.GetAll();
            return Ok(clientsDTO);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var clientDTO = await _clientService.GetById(Id);
            if (clientDTO == null)
            {
                return BadRequest("Cliente não encontrado.");
            }   
            return Ok(clientDTO);
            
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientDTO clientDTO)
        {
            var clientCreated = await _clientService.Create(clientDTO);
            if (clientCreated == null)
            {
                return BadRequest("Ocorreu um erro ao criar o cliente.");
            }
            return Ok("Cliente criado com sucesso!");
            
        }

        [HttpPut]
        public async Task<IActionResult> Update(ClientDTO clientDTO)
        {
            var clientUpdated = await _clientService.Update(clientDTO);
            if (clientUpdated == null)
            {
                return BadRequest("Ocorreu um erro ao atualizar o cliente.");
            }
            return Ok("Cliente atualizado com sucesso!");
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var clientDeleted = await _clientService.Delete(Id);
            if (clientDeleted == null)
            {
                return BadRequest("Ocorreu um erro ao deletar o cliente.");
            }
            return Ok("Cliente deletado com sucesso!");
        }
    }
}
