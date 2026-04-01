using CarExplorer.Application.Interfaces;
using CarExplorer.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarExplorer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IvehicleService _service;
        public VehiclesController(IvehicleService service)
        {
            _service = service;
        }

        [HttpGet("makes")]
        public async Task<IActionResult> GetMakes()
        {
            var result = await _service.GetMakesAsync();
            return Ok(result);
        }

        [HttpGet("vehicle-types")]
        public async Task<IActionResult> GetVehicleTypes(int makeId)
        {
            var result = await _service.GetVehicleTypesAsync(makeId);
            return Ok(result);
        }

        [HttpGet("models")]
        public async Task<IActionResult> GetModels(int makeId, int year)
        {
            var result = await _service.GetModelsAsync(makeId, year);
            return Ok(result);
        }
    }
}
