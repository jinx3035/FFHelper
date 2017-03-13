using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FFHelper.Models;

namespace FFHelper.Controllers
{
    public class TeamsController : Controller
    {
        
        public ActionResult LoadTeams()
        {
            List<SelectListItem> Team = new List<SelectListItem>();
            Team.Add(new SelectListItem { Text = "Select", Value = "0" });
            Team.Add(new SelectListItem { Text = "Milwaukee Brewers", Value = "1" });
            Team.Add(new SelectListItem { Text = "Srilanka", Value = "2" });
            Team.Add(new SelectListItem { Text = "China", Value = "3" });
            Team.Add(new SelectListItem { Text = "Austrila", Value = "4" });
            Team.Add(new SelectListItem { Text = "USA", Value = "5" });
            Team.Add(new SelectListItem { Text = "UK", Value = "6" });
            ViewData["team"] = Team;
            return View();
        }
        //    private ApplicationDbContext db = new ApplicationDbContext();

        //    // GET: Teams
        //    public ActionResult Index()
        //    {
        //        return View(db.Team.ToList());
        //    }

        //    // GET: Teams/Details/5
        //    public ActionResult Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Team team = db.Team.Find(id);
        //        if (team == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(team);
        //    }

        //    // GET: Teams/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Teams/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create([Bind(Include = "Id,Name,ApiTeamId")] Team team)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Team.Add(team);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        return View(team);
        //    }

        //    // GET: Teams/Edit/5
        //    public ActionResult Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Team team = db.Team.Find(id);
        //        if (team == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(team);
        //    }

        //    // POST: Teams/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit([Bind(Include = "Id,Name,ApiTeamId")] Team team)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Entry(team).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(team);
        //    }

        //    // GET: Teams/Delete/5
        //    public ActionResult Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Team team = db.Team.Find(id);
        //        if (team == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(team);
        //    }

        //    // POST: Teams/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult DeleteConfirmed(int id)
        //    {
        //        Team team = db.Team.Find(id);
        //        db.Team.Remove(team);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
    }
}
