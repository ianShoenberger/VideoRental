using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We've got you covered. Stocking films that amaze, excite, scare, and inspire is our specialty. Est. 2016";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Call Lumbardh for any issues you might have, or if you just need someone to chat with.";

            return View();
        }
    }
}