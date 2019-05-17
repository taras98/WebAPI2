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
            db.Order.Add(o1);
            db.Order.Add(o2);
            db.Order.Add(o3);
            db.SaveChanges();
            Product p1 = new Product { Id = Guid.NewGuid(), Name = "p1", Price = 100 };
            Product p2 = new Product { Id = Guid.NewGuid(), Name = "p2", Price = 100 };
            Product p3 = new Product { Id = Guid.NewGuid(), Name = "p3", Price = 100 };
            db.Product.Add(p1);
            db.Product.Add(p2);
            db.Product.Add(p3);
            db.SaveChanges();

            OrderProduct op1 = new OrderProduct { Id = Guid.NewGuid(), Order = o1, Product = p1 };
            OrderProduct op2 = new OrderProduct { Id = Guid.NewGuid(), Order = o1, Product = p2 };
            OrderProduct op3 = new OrderProduct { Id = Guid.NewGuid(), Order = o2, Product = p1 };
            OrderProduct op4 = new OrderProduct { Id = Guid.NewGuid(), Order = o2, Product = p2 };
            db.OrderProduct.AddRange(new List<OrderProduct> { op1, op2, op3, op4 });
            db.SaveChanges();

            base.Seed(db);
        }
    }
}