using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task3.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
            ViewBag.Name = form["Name"];
            ViewBag.PhoneNumber = form["PhoneNumber"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Degree = form["Degree"];
            ViewBag.Interests = form.GetValues("Interests");


            return View();
        }
    }
}