using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task3.Controllers
{
    public class LoginController : Controller
    {
        private static readonly (string Username, string Password)[] validCredentials =
        {
            ("user1", "password1"),
            ("user2", "password2"),
        };

        // GET: Login/LoginPage
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login/LoginPage
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            bool isValidUser = validCredentials.Any(c => c.Username == username && c.Password == password);

            if (isValidUser)
            {
                Session["User"] = username;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }

        // GET: Login/Logout
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}