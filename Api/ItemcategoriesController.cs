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
using SuitappRest.Context;

namespace SuitappRest.Api
{
    public class ItemcategoriesController : ApiController
    {
        private SuitAppResDB db = new SuitAppResDB();

        // GET: api/Itemcategories
        public IQueryable<ItemCategory> GetItemCategories()
        {
            return db.ItemCategories;
        }

        // GET: api/Itemcategories/5
        [ResponseType(typeof(ItemCategory))]
        public IHttpActionResult GetItemCategory(int id)
        {
            ItemCategory itemCategory = db.ItemCategories.Find(id);
            if (itemCategory == null)
            {
                return NotFound();
            }

            return Ok(itemCategory);
        }

        // PUT: api/Itemcategories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutItemCategory(int id, ItemCategory itemCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != itemCategory.CategoryID)
            {
                return BadRequest();
            }

            db.Entry(itemCategory).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemCategoryExists(id))
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

        // POST: api/Itemcategories
        [ResponseType(typeof(ItemCategory))]
        public IHttpActionResult PostItemCategory(ItemCategory itemCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ItemCategories.Add(itemCategory);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = itemCategory.CategoryID }, itemCategory);
        }

        // DELETE: api/Itemcategories/5
        [ResponseType(typeof(ItemCategory))]
        public IHttpActionResult DeleteItemCategory(int id)
        {
            ItemCategory itemCategory = db.ItemCategories.Find(id);
            if (itemCategory == null)
            {
                return NotFound();
            }

            db.ItemCategories.Remove(itemCategory);
            db.SaveChanges();

            return Ok(itemCategory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemCategoryExists(int id)
        {
            return db.ItemCategories.Count(e => e.CategoryID == id) > 0;
        }
    }
}