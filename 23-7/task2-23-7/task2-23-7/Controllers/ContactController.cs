using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task2_23_7.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Display(FormCollection form)
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