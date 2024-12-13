using Microsoft.EntityFrameworkCore;
using RestApiWithDb.Models;

namespace RestApiWithDb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=db;Port=5432;Database=restapi_db;Username=postgres;Password=postgres");
            }
        }
    }
}
