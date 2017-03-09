using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFHelper.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpPost]

        public ActionResult Index()
        {
            return View();
        }
    }
}