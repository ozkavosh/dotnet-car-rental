using Bigger.CrudCars.Application.DTOs;
using Bigger.CrudCars.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bigger.CrudCars.WebApi.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        private readonly CarService _carService;

        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarResponseDto>>> GetCars()
        {
            return await _carService.GetAllCarsAsync();
        }

        [HttpPost]
        public async Task<ActionResult<CarResponseDto>> CreateCar([FromBody] CarCreateDto carCreateDto)
        {
            var createdCar = await _carService.CreateCarAsync(carCreateDto);
            return CreatedAtAction(nameof(CreateCar), new { id = createdCar.Id }, createdCar);
        }
    }
}
