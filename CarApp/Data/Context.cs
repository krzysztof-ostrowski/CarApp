using CarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CarApp.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
