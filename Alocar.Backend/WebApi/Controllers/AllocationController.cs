using Application.DTOs;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllocationController : Controller
    {

        private readonly IAllocationService _allocationService;

        public AllocationController(IAllocationService allocationService)
        {
            _allocationService = allocationService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allocationDTO = await _allocationService.GetAll();
            return Ok(allocationDTO);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var allocationDTO = await _allocationService.GetById(Id);
            if (allocationDTO == null)
            {
                return BadRequest("allocatione não encontrado.");
            }
            return Ok(allocationDTO);

        }

        [HttpPost]
        public async Task<IActionResult> Create(AllocationDTO allocationDTO)
        {
            var allocationCreated = await _allocationService.Create(allocationDTO);
            if (allocationCreated == null)
            {
                return BadRequest("Ocorreu um erro ao criar o allocatione.");
            }
            return Ok("allocatione criado com sucesso!");

        }

        [HttpPut]
        public async Task<IActionResult> Update(AllocationDTO allocationDTO)
        {
            var allocationUpdated = await _allocationService.Update(allocationDTO);
            if (allocationUpdated == null)
            {
                return BadRequest("Ocorreu um erro ao atualizar o allocatione.");
            }
            return Ok("allocatione atualizado com sucesso!");
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var allocationDeleted = await _allocationService.Delete(Id);
            if (allocationDeleted == null)
            {
                return BadRequest("Ocorreu um erro ao deletar o allocatione.");
            }
            return Ok("allocatione deletado com sucesso!");
        }
    }
}
