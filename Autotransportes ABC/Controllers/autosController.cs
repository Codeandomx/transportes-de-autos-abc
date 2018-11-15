using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Autotransportes_ABC.Models;

namespace Autotransportes_ABC.Controllers
{
    public class autosController : Controller
    {
        private transportesEntities1 db = new transportesEntities1();

        // GET: autos
        public ActionResult Index()
        {
            return View(db.autos.ToList());
        }

        // GET: autos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            autos autos = db.autos.Find(id);
            if (autos == null)
            {
                return HttpNotFound();
            }
            return View(autos);
        }

        // GET: autos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: autos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "folio,marca,modelo,color,tipo_transmicion,descripcion")] autos autos)
        {
            if (ModelState.IsValid)
            {
                db.autos.Add(autos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autos);
        }

        // GET: autos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            autos autos = db.autos.Find(id);
            if (autos == null)
            {
                return HttpNotFound();
            }
            return View(autos);
        }

        // POST: autos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "folio,marca,modelo,color,tipo_transmicion,descripcion")] autos autos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autos);
        }

        // GET: autos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            autos autos = db.autos.Find(id);
            if (autos == null)
            {
                return HttpNotFound();
            }
            return View(autos);
        }

        // POST: autos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            autos autos = db.autos.Find(id);
            db.autos.Remove(autos);
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
