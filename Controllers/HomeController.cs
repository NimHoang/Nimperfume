using Perfume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perfume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()  
        {
            ProductDbContext dbContext = new ProductDbContext();
            List<Products> Product = dbContext.Product.ToList();
            return View(Product);
        }
        public ActionResult About() { return View(); }
        public ActionResult Shop()  { return View(); }
        public ActionResult Contact()  { return View(); }
        public ActionResult Blog() { return View(); }
        public ActionResult ShoppingCart() { return View(); }
        public ActionResult Register() { return View(); }
        public ActionResult Login() { return View(); }
        public ActionResult Checkout() { return View(); }
        public ActionResult Collectiongirl(){ return View(); }
        public ActionResult Collectionman() { return View(); }
    }
}