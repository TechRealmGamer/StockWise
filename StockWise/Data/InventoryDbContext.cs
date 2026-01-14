using Microsoft.EntityFrameworkCore;
using StockWise.Models;

namespace StockWise.Data
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=stockwise.db");
        }
    }
}
