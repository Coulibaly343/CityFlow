using CityFlow.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace CityFlow.Infrastructure.Data
{
    public class CityFlowContext : DbContext
    {
        public CityFlowContext(DbContextOptions<CityFlowContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
