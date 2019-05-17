using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public decimal Amount { get; set; }

        public ICollection<OrderProduct> OrderProduct { get; set; }
        public Order()
        {
            OrderProduct = new List<OrderProduct>();
        }
    }
}