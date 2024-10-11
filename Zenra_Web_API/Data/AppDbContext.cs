using Microsoft.EntityFrameworkCore;
using Zenra_Web_API.Models;

namespace Zenra_Web_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<YourEntity> YourEntities { get; set; }
    }
}
