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
    public class KotController : ApiController
    {
        private SuitAppResDB db = new SuitAppResDB();

        // GET: api/Kot
        public IQueryable<KOT> GetKOTs()
        {
            return db.KOTs;
        }

        // GET: api/Kot/5
        [ResponseType(typeof(KOT))]
        public IHttpActionResult GetKOT(int id)
        {
            KOT kOT = db.KOTs.Find(id);
            if (kOT == null)
            {
                return NotFound();
            }

            return Ok(kOT);
        }

        // PUT: api/Kot/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKOT(int id, KOT kOT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kOT.KOID)
            {
                return BadRequest();
            }

            db.Entry(kOT).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KOTExists(id))
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

        // POST: api/Kot
        [ResponseType(typeof(KOT))]
        public IHttpActionResult PostKOT(KOT kOT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var count = db.KOTs.Count(p => p.SuitApp_Id == kOT.SuitApp_Id);
            if (count == 0)
            {
                var data = db.KOTs.Count(p => p.Date == kOT.Date && p.Series == kOT.Series);
                int token = data + 1;
                kOT.TokenNo = kOT.Series +" - "+ token;

                db.KOTs.Add(kOT);
                db.SaveChanges();
            }
            else
            {
                var updated = db.KOTs.SingleOrDefault(p => p.SuitApp_Id == kOT.SuitApp_Id);


                updated.NetAmt = kOT.NetAmt;
                updated.ModifiedBy = kOT.ModifiedBy;
                updated.ModifiedDate = kOT.ModifiedDate;
                updated.DeletedBy = kOT.DeletedBy;
                updated.DeletedDate = kOT.DeletedDate;
                updated.IsDeleted = kOT.IsDeleted;
                db.Entry(updated).State = EntityState.Modified;
               
                db.DeleteKotDetailsBySuitAppID(kOT.SuitApp_Id);
                db.SaveChanges();

                var data2 = db.KOTs.SingleOrDefault(p => p.KOID == updated.KOID);


                KOT kot = new KOT() {
                    KOID = data2.KOID, 
                    SuitApp_Id = data2.SuitApp_Id,
                    TokenNo = data2.TokenNo
                };
                

                return CreatedAtRoute("DefaultApi", new { id = updated.KOID }, kot);
            }


            return CreatedAtRoute("DefaultApi", new { id = kOT.KOID }, kOT);
        }

        // DELETE: api/Kot/5
        [ResponseType(typeof(KOT))]
        public IHttpActionResult DeleteKOT(int id)
        {
            KOT kOT = db.KOTs.Find(id);
            if (kOT == null)
            {
                return NotFound();
            }

            db.KOTs.Remove(kOT);
            db.SaveChanges();

            return Ok(kOT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KOTExists(int id)
        {
            return db.KOTs.Count(e => e.KOID == id) > 0;
        }
    }
}