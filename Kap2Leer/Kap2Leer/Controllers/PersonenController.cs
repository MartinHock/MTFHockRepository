using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kap2Leer.Controllers
{
    public class PersonenController : Controller
    {
        // GET: Personen
        public ActionResult Index()
        {
            return View();
        }

        // GET: Personen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personen/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personen/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personen/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
