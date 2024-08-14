using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miniEcommerce.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(string name, int price, string imageUrl)
        {
            if (Session["Products"] == null)
            {
                Session["Products"] = new List<string[]>();
            }
            List<string[]> products = (List<string[]>)Session["Products"];

            string[] product = new string[3];
            product[0] = name;
            product[1] = imageUrl;
            product[2] = price.ToString();

            products.Add(product);

            Session["Products"] = products;

            return RedirectToAction("Index");
        }
    }
}