using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vcef01.Controllers
{
    public class ShopsController : Controller
    {
        // GET: Shops
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Shops/preferred
        [Authorize]
        public ActionResult Preferred()
        {
            return View();
        }
    }
}