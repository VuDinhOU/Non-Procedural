using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NonProcedural.Controllers
{
    public class AnimeController : Controller
    {
        // GET: Anime
        public ActionResult Anime()
        {
            return View();
        }
    }
}