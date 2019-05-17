using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<OrderProduct> OrderProduct { get; set; }
        public Product()
        {
            OrderProduct = new List<OrderProduct>();
        }
    }
}