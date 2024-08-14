using miniEcommerceWithClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miniEcommerceWithClass.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                if (Session["Products"] == null)
                {
                    Session["Products"] = new List<string[]>();
                }

                List<string[]> products = (List<string[]>)Session["Products"];

                string[] productArray = new string[3];
                productArray[0] = product.Name;
                productArray[1] = product.Image;
                productArray[2] = product.Price.ToString();

                products.Add(productArray);

                Session["Products"] = products;

                return RedirectToAction("Index");
            }

            return View("Index", product);
        }
    }
}