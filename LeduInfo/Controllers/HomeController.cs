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
        public ActionResult Index(string userName="")
        {
            ViewBag.Message = userName;
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

        public ActionResult Vote()
        {
            ViewBag.Message = "Vote for your topic!";

            return View();
        }
        public ActionResult CommunityDesigner()
        {
            SilverlightObject uploadControl = new SilverlightObject
            {
                XapName = "CommunityDesigner",
                Size=new System.Drawing.Size(800,800)
            };
            UploadViewModel model = new UploadViewModel()
            {
                UploadControl = uploadControl
            };
            return View(model);
        }
    }
}
