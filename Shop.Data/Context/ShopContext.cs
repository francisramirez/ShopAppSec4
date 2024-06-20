

using Microsoft.EntityFrameworkCore;
using Shop.Data.Entities;

namespace Shop.Data.Context
{
    public class ShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ShopDb");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
