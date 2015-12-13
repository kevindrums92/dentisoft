using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentisoftAPI.Controllers
{
    public class ZonaController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Customer Page";

            return View();
        }
    }
}
