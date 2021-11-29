using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_8_ReedWest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your projects page.";

            return View();

        }

        public ActionResult EmploymentHistory()
        {
            ViewBag.Message = "Your Employment history";
            return View();
        }
    }
}