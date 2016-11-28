using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public double Media()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach (int x in list)
                sum += x;
            return sum / list.Count;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloWorld()
        {
            return Content("Hello World!");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Autor = " Roxana";

            var model = new AboutModel();
            model.Message = "Hello!";
            model.Author = "JB";

            return View(model);


           // return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}