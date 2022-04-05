using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillhopStore.Models;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Models;

namespace WebAPI.Data
{
    public class WebShopDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = WebShopDB; Trusted_Connection = True; ");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
