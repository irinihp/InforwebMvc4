using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeduInfo.Models;

namespace LeduInfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            return View();
        }
        /// action for About view
        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }

        public ActionResult LeduIndex()
        {
            ViewBag.Message = "Your Info system for renting.";
            return View();
        }

        public ActionResult InfoPage()
        {
            ViewBag.Message = "This is the info page for user to search!";
            return View();
        }
    }
}
