using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMVC.Controllers
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
        public ActionResult Register()
        {
            ViewBag.Message = "this is a Register page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "this is a login page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "this is a user services page.";

            return View();
        }



    }
}