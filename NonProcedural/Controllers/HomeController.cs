using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NonProcedural.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Create";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Page";
            return View();
                
        }

        public ActionResult Policy()
        {
            ViewBag.Title = "Policy Page";
            return View();
        }

        public ActionResult Success()
        {
            ViewBag.Title = "Success Page";
            return View();

        }

        public ActionResult Product()
        {
            ViewBag.Title = "Product Page";
            return View();

        }
        public ActionResult Thanks()
        {
            ViewBag.Title = "Thanks Page";
            return View();

        }

        public ActionResult Account()
        {
            ViewBag.Title = "Account Page";
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Title = "About Page";
            return View();

        }
    }
}
