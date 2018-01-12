using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDInc.Classes;
using DDInc.Models;

namespace DDInc.Controllers
{
    public class DefaultControllerController : Controller
    {
        // GET: DefaultController
        public ActionResult DefaultAction()
        {
            Simple s = new Simple();
            s.Name = "DD";
            s.Email = "xxx@gmail.com";

            return View(s);
        }
    }
}