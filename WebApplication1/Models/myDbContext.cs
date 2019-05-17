using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class myDbContext:DbContext  
    {
        public myDbContext()
            :base ("connection")
        { }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }

    }
}