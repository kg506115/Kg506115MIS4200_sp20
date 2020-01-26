using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kg506115MIS4200_sp20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Meet Kirsten Gill";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Student Contact Information";

            return View();
        }
    }
}