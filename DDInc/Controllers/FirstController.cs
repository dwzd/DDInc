using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDInc.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            ViewBag.Number = 88;
            ViewBag.Message = "This is a index Page!";
            ViewBag.DD = new List<string> { "dd1", "dd2", "dd3" };
            return View();
        }

        //public string Index(string id)
        //{
        //    return "<h1>This is a first controller index page!</h1><br/> You ID is " + id;
        //}

        //public string Another()
        //{
        //    return "This is a first controller another page.";
        //}
    }
}