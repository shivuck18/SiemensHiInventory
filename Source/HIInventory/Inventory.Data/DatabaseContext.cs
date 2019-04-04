using Microsoft.EntityFrameworkCore;
using System;

namespace Inventory.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options){ }

    }
}
