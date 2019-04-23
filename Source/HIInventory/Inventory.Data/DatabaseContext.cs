using Inventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


        public DbSet<Platform> platforms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().ToTable("Platform");
        }
    }
}
