using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UoRebar_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the UO Rebar Shard's Website!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
