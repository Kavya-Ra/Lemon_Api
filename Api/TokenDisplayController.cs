using SuitappRest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuitappRest.Api
{
    public class TokenDisplayController : Controller
    {
        SuitAppResDB db = new SuitAppResDB();
        // GET: TokenDisplay
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Token()
        {
            List<KOT> studreg = db.KOTs.Where(a => a.IsRevoke == 1 && a.IsDeleted == 0).ToList();
            return View(studreg);
        }
    }
}