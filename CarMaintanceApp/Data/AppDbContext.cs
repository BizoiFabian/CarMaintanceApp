using CarMaintanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CarMaintanceApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CarMaintenance> CarMaintenances { get; set; }
    }
}
