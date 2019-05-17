using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Initializzer: DropCreateDatabaseAlways<myDbContext>
    {
        protected override void Seed(myDbContext db)
        {
            OrderProduct op1 = new OrderProduct { Id = Guid.NewGuid(), Order = o1, Product = p1 };
            Order o1 = new Order { Id = Guid.NewGuid(), OrderProduct= new List<OrderProduct>() { op1} };
            db.Order.Add(new Order { Id = Guid.NewGuid(), Number = "ooo", Amount= 100, OrderProduct=});
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Year = 1896 });

            base.Seed(db);
        }
    }
}