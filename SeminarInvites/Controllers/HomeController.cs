using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeminarInvites.Models;
namespace SeminarInvites.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home

        //public String Index()
        //{
        //    return "<h1><b>Hello World</b></h1>";
        //}

        public ActionResult ViewPage1()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good afternoon";
            return View();
        }
        
        public ViewResult ViewPage2()
        {
            return View();
        }
        public ActionResult registerguest()
        {
            return View();
        }

        [HttpPost]
        public ViewResult registerguest(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                using (var context = new GuestContextdb())
                {
                    context.GuestResponses.Add(guestResponse);
                    context.SaveChanges();
                }
                    return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

    }
}