using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kap2Asynchron.Models;
using Kap2Standard.Models;

namespace Kap2Asynchron.Controllers
{
    public class MitarbeiterasynchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Mitarbeiters
        public async Task<ActionResult> Index()
        {
            return View(await db.Mitarbeiters.ToListAsync());
        }

        // GET: Mitarbeiters/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = await db.Mitarbeiters.FindAsync(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // GET: Mitarbeiters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mitarbeiters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Vorname,Nachname,Geburtstag,Gehalt")] Mitarbeiter mitarbeiter)
        {
            if (ModelState.IsValid)
            {
                db.Mitarbeiters.Add(mitarbeiter);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(mitarbeiter);
        }

        // GET: Mitarbeiters/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = await db.Mitarbeiters.FindAsync(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // POST: Mitarbeiters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Vorname,Nachname,Geburtstag,Gehalt")] Mitarbeiter mitarbeiter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mitarbeiter).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mitarbeiter);
        }

        // GET: Mitarbeiters/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = await db.Mitarbeiters.FindAsync(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // POST: Mitarbeiters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Mitarbeiter mitarbeiter = await db.Mitarbeiters.FindAsync(id);
            db.Mitarbeiters.Remove(mitarbeiter);
            await db.SaveChangesAsync();
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
