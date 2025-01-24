using Microsoft.EntityFrameworkCore;
using Bigger.CrudCars.Domain;

namespace Bigger.CrudCars.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}