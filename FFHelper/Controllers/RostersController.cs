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
    public class RostersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rosters
        public ActionResult Index()
        {
            return View(db.Roster.ToList());
        }

        // GET: Rosters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roster roster = db.Roster.Find(id);
            if (roster == null)
            {
                return HttpNotFound();
            }
            return View(roster);
        }

        // GET: Rosters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rosters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Position,Team,IsStarting")] Roster roster)
        {
            if (ModelState.IsValid)
            {
                db.Roster.Add(roster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roster);
        }

        // GET: Rosters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roster roster = db.Roster.Find(id);
            if (roster == null)
            {
                return HttpNotFound();
            }
            return View(roster);
        }

        // POST: Rosters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Position,Team,IsStarting")] Roster roster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roster);
        }

        // GET: Rosters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roster roster = db.Roster.Find(id);
            if (roster == null)
            {
                return HttpNotFound();
            }
            return View(roster);
        }

        // POST: Rosters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Roster roster = db.Roster.Find(id);
            db.Roster.Remove(roster);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
