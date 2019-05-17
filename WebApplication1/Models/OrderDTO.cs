using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string OrderProductId { get; set; }
    }
}