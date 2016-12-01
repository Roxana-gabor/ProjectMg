using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ActionResultController:Controller
    {
        // Tema exercitiul 8 
        public ActionResult RedirectPermanent()
        {
            return RedirectPermanent(@"https://www.google.com");
        }

        public ActionResult Index()
        {
            return Content("This message is sent from the Index action! ");
        }
        public ActionResult RedirectToActionInTheSameController()
        {
            return RedirectToAction("Index");
        }
        // Tema exercitul 9
        public ActionResult RedirectToActionInHomeController()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute(new { controller = "Home", action = "About" });
        }

        public ActionResult ReturnFile()
        {
            return File("~Content/Site.css", "text/css");
        }
    }
}