using JobApplicant.App.Models;
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

            return View(ModelBuilder.List());
        }

        public ActionResult New()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult New(Applicant applicant)
        {
            if (!ModelState.IsValid)
                return View();

            ModelBuilder.Add(applicant);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ModelBuilder.Delete(id);
            return RedirectToAction("List");
        }
    }
    
}