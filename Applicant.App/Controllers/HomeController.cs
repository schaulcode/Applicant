using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobApplicant.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult List()
        {

            return View();
        }

        public ActionResult New()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}