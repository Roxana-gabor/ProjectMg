using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController:Controller
    {
        public ActionResult DoAnAction()
        {
            return Content("Hello world!");
        }

        public ActionResult HelloUser(string alpha)
        {
            var encodeName = Server.HtmlEncode(alpha);
            // return Content("Hello" + alpha);
            return Content("Hello Roxana", encodeName);
        }
    }
}