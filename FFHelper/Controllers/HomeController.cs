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

        //public ActionResult LoadTeams()
        //{
        //    List<SelectListItem> Team = new List<SelectListItem>();
        //    Team.Add(new SelectListItem { Text = "Select", Value = "0" });
        //    Team.Add(new SelectListItem { Text = "Milwaukee Brewers", Value = "1" });
        //    Team.Add(new SelectListItem { Text = "Srilanka", Value = "2" });
        //    Team.Add(new SelectListItem { Text = "China", Value = "3" });
        //    Team.Add(new SelectListItem { Text = "Austrila", Value = "4" });
        //    Team.Add(new SelectListItem { Text = "USA", Value = "5" });
        //    Team.Add(new SelectListItem { Text = "UK", Value = "6" });
        //    ViewData["team"] = Team;
        //    return View();
        //}

        //private IEnumerable<SelectListItem> GetTeams()
        //{
        //    var UserViewModel = new UserViewModel();
        //    var teams = UserViewModel
        //                .GetTeams()
        //                .Select(x =>
        //                        new SelectListItem
        //                        {
        //                            Value = x.UserRoleId.ToString(),
        //                            Text = x.UserRole
        //                        });

        //    return new SelectList(teams, "Value", "Text");
        //}


        //public ActionResult AddNewTeam()
        //{
        //    var model = new UserRoleViewModel
        //    {
        //        UserRoles = GetTeams()
        //    };
        //    return View(model);
        //}

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