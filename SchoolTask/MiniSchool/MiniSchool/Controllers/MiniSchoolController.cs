using MiniSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniSchool.Controllers
{
    public class MiniSchoolController : Controller
    {
        private readonly MiniSchoolContext _context = new MiniSchoolContext();

        // GET: MiniSchool
        public ActionResult Index()
        {
            // Fetch classes from the database
            var classes = _context.Classes.ToList();

            // Pass classes to the view
            ViewBag.Classes = classes;

            return View();
        }
    }
}