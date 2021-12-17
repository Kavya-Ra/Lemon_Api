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
    public class KotdetailsController : ApiController
    {
        private SuitAppResDB db = new SuitAppResDB();

        // GET: api/Kotdetails
        public IQueryable<KOTDetail> GetKOTDetails()
        {
            return db.KOTDetails;
        }

        // GET: api/Kotdetails/5
        [ResponseType(typeof(KOTDetail))]
        public IHttpActionResult GetKOTDetail(int id)
        {
            KOTDetail kOTDetail = db.KOTDetails.Find(id);
            if (kOTDetail == null)
            {
                return NotFound();
            }

            return Ok(kOTDetail);
        }

        // PUT: api/Kotdetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKOTDetail(int id, KOTDetail kOTDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kOTDetail.KDID)
            {
                return BadRequest();
            }

            db.Entry(kOTDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KOTDetailExists(id))
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

        // POST: api/Kotdetails
        [ResponseType(typeof(List<KOTDetail>))]
        public IHttpActionResult PostKOTDetail(List<KOTDetail> kOTDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
          
            foreach (var item in kOTDetail)
            {
                db.KOTDetails.Add(item);
                db.SaveChanges();
           

            }
            return Ok(kOTDetail);

        }

        // DELETE: api/Kotdetails/5
        [ResponseType(typeof(KOTDetail))]
        public IHttpActionResult DeleteKOTDetail(int id)
        {
            KOTDetail kOTDetail = db.KOTDetails.Find(id);
            if (kOTDetail == null)
            {
                return NotFound();
            }

            db.KOTDetails.Remove(kOTDetail);
            db.SaveChanges();

            return Ok(kOTDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KOTDetailExists(int id)
        {
            return db.KOTDetails.Count(e => e.KDID == id) > 0;
        }
    }
}