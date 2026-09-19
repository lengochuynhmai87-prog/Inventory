using Microsoft.EntityFrameworkCore;
using Inventory.Model;

namespace Inventory.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Warehouse> warehouses{get; set;}
}
    
