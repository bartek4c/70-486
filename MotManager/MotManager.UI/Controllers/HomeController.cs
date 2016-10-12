using MotManager.Data;
using MotManager.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MotManager.UI.Controllers
{
    //[Route("home/{action}")]
    public class HomeController : Controller
    {
        //[Route("home")]
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var car = db.Cars.FirstOrDefault();

            return View(car);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}