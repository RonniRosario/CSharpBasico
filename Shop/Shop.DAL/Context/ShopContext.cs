

using Microsoft.EntityFrameworkCore;
using Shop.DAL.Entities;
using System.Security.Cryptography;

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
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Products>().Property(p => p.unitprice).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Employees>().Property(e => e.birthdate).HasColumnType("datetime");
            modelBuilder.Entity<Employees>().Property(e => e.hiredate).HasColumnType("datetime");
        }
    }

}
