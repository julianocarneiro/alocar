using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicleDTO = await _vehicleService.GetAll();
            return Ok(vehicleDTO);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var vehicleDTO = await _vehicleService.GetById(Id);
            if (vehicleDTO == null)
            {
                return BadRequest("Veiculo não encontrado.");
            }
            return Ok(vehicleDTO);

        }

        [HttpPost]
        public async Task<IActionResult> Create(VehicleDTO vehicleDTO)
        {
            var vehicleCreated = await _vehicleService.Create(vehicleDTO);
            if (vehicleCreated == null)
            {
                return BadRequest("Ocorreu um erro ao criar o Veiculo.");
            }
            return Ok("Veiculo criado com sucesso!");

        }

        [HttpPut]
        public async Task<IActionResult> Update(VehicleDTO vehicleDTO)
        {
            var vehicleUpdated = await _vehicleService.Update(vehicleDTO);
            if (vehicleUpdated == null)
            {
                return BadRequest("Ocorreu um erro ao atualizar o Veiculo.");
            }
            return Ok("Veiculo atualizado com sucesso!");
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var vehicleDeleted = await _vehicleService.Delete(Id);
            if (vehicleDeleted == null)
            {
                return BadRequest("Ocorreu um erro ao deletar o Veiculo.");
            }
            return Ok("Veiculo deletado com sucesso!");
        }
    }
}
