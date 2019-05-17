using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrderProductsController : ApiController
    {
        private myDbContext db = new myDbContext();

        // GET: api/OrderProducts
        public IQueryable<OrderProduct> GetOrderProduct()
        {
            return db.OrderProduct;
        }

        // GET: api/OrderProducts/5
        [ResponseType(typeof(OrderProduct))]
        public IHttpActionResult GetOrderProduct(Guid id)
        {
            OrderProduct orderProduct = db.OrderProduct.Find(id);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return Ok(orderProduct);
        }

        // PUT: api/OrderProducts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrderProduct(Guid id, OrderProduct orderProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderProduct.Id)
            {
                return BadRequest();
            }

            db.Entry(orderProduct).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/OrderProducts
        [ResponseType(typeof(OrderProduct))]
        public IHttpActionResult PostOrderProduct(OrderProduct orderProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OrderProduct.Add(orderProduct);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (OrderProductExists(orderProduct.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = orderProduct.Id }, orderProduct);
        }

        // DELETE: api/OrderProducts/5
        [ResponseType(typeof(OrderProduct))]
        public IHttpActionResult DeleteOrderProduct(Guid id)
        {
            OrderProduct orderProduct = db.OrderProduct.Find(id);
            if (orderProduct == null)
            {
                return NotFound();
            }

            db.OrderProduct.Remove(orderProduct);
            db.SaveChanges();

            return Ok(orderProduct);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderProductExists(Guid id)
        {
            return db.OrderProduct.Count(e => e.Id == id) > 0;
        }
    }
}