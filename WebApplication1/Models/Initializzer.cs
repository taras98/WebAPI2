using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Initializzer : DropCreateDatabaseAlways<myDbContext>
    {
        protected override void Seed(myDbContext db)
        {

            Order o1 = new Order { Id = Guid.NewGuid(), Number = "o1", Amount = 100 };
            Order o2 = new Order { Id = Guid.NewGuid(), Number = "o2", Amount = 100 };
            Order o3 = new Order { Id = Guid.NewGuid(), Number = "o3", Amount = 100 };
            db.Orders.Add(o1);
            db.Orders.Add(o2);
            db.Orders.Add(o3);
            db.SaveChanges();
            Product p1 = new Product { Id = Guid.NewGuid(), Name = "p1", Price = 100 };
            Product p2 = new Product { Id = Guid.NewGuid(), Name = "p2", Price = 100 };
            Product p3 = new Product { Id = Guid.NewGuid(), Name = "p3", Price = 100 };
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Products.Add(p3);
            db.SaveChanges();

            OrderProduct op1 = new OrderProduct { Id = Guid.NewGuid(), Orders = o1, Products = p1 };
            OrderProduct op2 = new OrderProduct { Id = Guid.NewGuid(), Orders = o1, Products = p2 };
            OrderProduct op3 = new OrderProduct { Id = Guid.NewGuid(), Orders = o2, Products = p1 };
            OrderProduct op4 = new OrderProduct { Id = Guid.NewGuid(), Orders = o2, Products = p2 };
            db.OrderProducts.AddRange(new List<OrderProduct> { op1, op2, op3, op4 });
            db.SaveChanges();

            base.Seed(db);
        }
    }
}