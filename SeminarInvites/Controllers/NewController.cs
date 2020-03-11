using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarInvites.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        //public String Index()
        //{
        //    return "<h1> New Controller </h1>";
        //}

        public ActionResult ViewPage1()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good afternoon";
            return View();
        }
    }
}