using FFHelper.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace FFHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(User.IsInRole("Admin"))
            {
                return View("AdminIndex");
            }
            else if(User.IsInRole("User"))
            {
                return View("UserIndex");
            }
            else
            {
                return View();
            }
        }

        public  ActionResult About()
        {
            //SportRadar sportRadar = new SportRadar();
            //await sportRadar.ConsumeFootballPPAPI();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}