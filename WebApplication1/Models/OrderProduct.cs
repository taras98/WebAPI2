using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OrderProduct
    {
        public Guid Id { get; set; }
        [Required]
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }


        public virtual Order Orders { get; set; }
        public virtual Product Products { get; set; }
        
    }
}