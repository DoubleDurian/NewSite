using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasSite.Controllers
{
    public class HomeController : Controller
    {
        

        
        public ActionResult Studio()
        {//this is what should show up in the view by default
            ViewBag.Message = "Studio News";
            return View();
        }
        public ActionResult Nick()
        {//Nick's page
            
            return View();
        }
        public ActionResult Haseeb()
        {//Haseeb's page
            return View();
        }
        public ActionResult Tom()
        {//Tom's page
            return View();
        }
    }
}