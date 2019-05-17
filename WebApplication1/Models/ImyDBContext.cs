using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public interface ImyDBContext
    {
         DbSet<Order> Orders { get; set; }
         DbSet<Product> Products { get; set; }
         DbSet<OrderProduct> OrderProducts { get; set; }
    }
}