using NonProcedural.Models;
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
        public ActionResult Access(NonProcedural.Models.StoreLogin userModel)
        {
            using (CCLogEntities2 db = new CCLogEntities2())
            {
                var userDetails = db.StoreLogins;
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