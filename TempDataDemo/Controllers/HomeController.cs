using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Var1"] = "Message from View Data";
            ViewBag.Var2 = "Message from View Bag";
            TempData["Var3"] = "Message from Temp Data";
            string[] games = { "Cricket", "Baseball", "Football", "Hockey" };
            TempData["GamesArray"] = games;
            //return RedirectToAction("About");
            return RedirectToAction("Contact");
            //return View();
        }
        public ActionResult About()
        {
            if(TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }
            TempData.Keep();
            return View();
        }
        public ActionResult Contact()
        {
            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }
            return View();
        }
    }
}