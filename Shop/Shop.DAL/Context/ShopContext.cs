

using Microsoft.EntityFrameworkCore;
using Shop.DAL.Entities;

namespace Shop.DAL.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
    }
}
