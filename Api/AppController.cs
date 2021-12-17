using SuitappRest.Context;
using SuitappRest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace SuitappRest.Api
{
    public class AppController : ApiController
    {
        private SuitAppResDB db = new SuitAppResDB();

        [AcceptVerbs("POST")]
        [Route("api/app/login")]
        [ResponseType(typeof(AppLoginRes_Result))]
        public IHttpActionResult DeletePlan(AppLoginRes_Result appLogin)
        {
            AppLoginRes_Result login = db.AppLoginRes(appLogin.UserName, appLogin.Password).FirstOrDefault();
            if (login == null)
            {
                return NotFound();
            }

            return Ok(login);
        }

        [AcceptVerbs("POST")]
        [Route("api/app/loginstatus")]
        [ResponseType(typeof(Login_status))]
        public IHttpActionResult DeletePlan(Login_status login_Status)
        {
            if (login_Status.Date == null && login_Status.Time == null)
            {
                return NotFound();
            }

            db.Login_status.Add(login_Status);
            db.SaveChanges();

            return Ok(login_Status);
        }

        [AcceptVerbs("GET")]
        [Route("api/app/GetBillNo/{UserId:int}")]
        [ResponseType(typeof(GetBillNo))]
        public IHttpActionResult GetBillNo(int UserId)
        {
            var data = db.GetBillNoByUserIdforKOT(UserId).FirstOrDefault();
        
            if (data == null)
            {
                return NotFound();
            }
            GetBillNo get = new GetBillNo();
            get.Billno = (int)data;
            return Ok(get);
        }


        [AcceptVerbs("GET")]
        [Route("api/app/GetTokenNotReady")]
        [ResponseType(typeof(KOT))]
        public IHttpActionResult GetTokenNotReady()
        {
            List<KOT> kot = db.KOTs.Where(a => a.IsReady == 0 && a.IsDeleted ==0).ToList();
            if (kot == null)
            {
                return NotFound();
            }
         
            return Ok(kot);
        }

    }
}
