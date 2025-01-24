using Bigger.CrudCars.Application.DTOs;
using Bigger.CrudCars.Domain;
using Bigger.CrudCars.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bigger.CrudCars.Application.Services
{
    public class CarService
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CarResponseDto>> GetAllCarsAsync()
        {
            return await _context.Cars
                .Select(car => new CarResponseDto
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year,
                    CreatedAt = car.CreatedAt,
                    UpdatedAt = car.UpdatedAt,
                }).ToListAsync();
        }

        public async Task<CarResponseDto> CreateCarAsync(CarCreateDto dto)
        {
            var car = new Car
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Year = dto.Year
            };

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return new CarResponseDto
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                Year = car.Year,
                CreatedAt = car.CreatedAt,
                UpdatedAt = car.UpdatedAt,
            };
        }
    }
}
