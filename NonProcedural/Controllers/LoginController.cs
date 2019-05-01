using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Access(OnlineStore.Models.Login userModel)
        {
            using (CustLog db = new CustLog())
            {
                var userDetails = db.CustomerLogins.Where(x => x.Username == userModel.Username && x.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username/password, HINT: USERNAME/PASSWORD is admin";
                    return View("index", userModel);
                }
                else
                {
                    Session["Username"] = userDetails.Username;
                    return RedirectToAction("Success", "Home");
                }
            }
        }
    }
}