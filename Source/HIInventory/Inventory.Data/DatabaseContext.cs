using Inventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Inventory.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


        public DbSet<Platform> MyProperty { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().ToTable("Platform");
        }
    }
}
