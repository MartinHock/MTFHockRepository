using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kap2Standard.Models;

namespace Kap2Standard.Controllers
{
    public class MitarbeiterController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Mitarbeiter
        public ActionResult Index()
        {
            return View(db.Mitarbeiters.ToList());
        }

        // GET: Mitarbeiter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // GET: Mitarbeiter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mitarbeiter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Vorname,Nachname,Geburtstag,Gehalt")] Mitarbeiter mitarbeiter)
        {
            if (ModelState.IsValid)
            {
                db.Mitarbeiters.Add(mitarbeiter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mitarbeiter);
        }

        // GET: Mitarbeiter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // POST: Mitarbeiter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Vorname,Nachname,Geburtstag,Gehalt")] Mitarbeiter mitarbeiter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mitarbeiter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mitarbeiter);
        }

        // GET: Mitarbeiter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // POST: Mitarbeiter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            db.Mitarbeiters.Remove(mitarbeiter);
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
