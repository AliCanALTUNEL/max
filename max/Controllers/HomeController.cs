using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace max.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "MAX || AnaSayfa";
            return View();
        }
        public ActionResult Slider()
        {
            return View();
        }
        public ActionResult info()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }  
        public ActionResult Counter()
        {
            return View();
        }   
        public ActionResult Block()
        {
            return View();
        }
    }
}