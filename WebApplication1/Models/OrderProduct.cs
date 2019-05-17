using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OrderProduct
    {
        public Guid Id { get; set; }
        //public Guid OrderId { get; set; }
        //public Guid ProductId { get; set; }
      
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}