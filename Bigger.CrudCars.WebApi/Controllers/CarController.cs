using Bigger.CrudCars.Application;
using Microsoft.AspNetCore.Mvc;

namespace Bigger.CrudCars.WebApi.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        [HttpGet("example")]
        public ActionResult<CarDto> GetExampleCar()
        {
            var carDto = new CarDto
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2022,
                CreatedAt = DateTime.Now,
                Id = 1,
            };
            return Ok(carDto);
        }
    }
}
