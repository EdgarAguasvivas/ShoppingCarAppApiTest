using Microsoft.EntityFrameworkCore;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Data.Context
{
    public class ShoppingCarAppContext : DbContext
    {
        public ShoppingCarAppContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}
