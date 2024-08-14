using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miniEcommerceWithClass.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            List<string[]> products = new List<string[]>();

            if (Session["Products"] != null)
            {
                products = (List<string[]>)Session["Products"];
            }

            return View(products);
        }
    }
}