using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using S5G5_PVFAPP.Models;

namespace S5G5_PVFAPP.Controllers
{
    public class UsesController : Controller
    {
        private PineValleyEntities db = new PineValleyEntities();

        // GET: Uses
        public ActionResult Index()
        {
            var uses = db.Uses.Include(u => u.Product).Include(u => u.RawMaterial);
            return View(uses.ToList());
        }

        // GET: Uses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uses uses = db.Uses.Find(id);
            if (uses == null)
            {
                return HttpNotFound();
            }
            return View(uses);
        }

        // GET: Uses/Create
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "ProductDescription");
            ViewBag.MaterialID = new SelectList(db.RawMaterial, "MaterialID", "MaterialName");
            return View();
        }

        // POST: Uses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaterialID,ProductID")] Uses uses)
        {
            if (ModelState.IsValid)
            {
                db.Uses.Add(uses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "ProductDescription", uses.ProductID);
            ViewBag.MaterialID = new SelectList(db.RawMaterial, "MaterialID", "MaterialName", uses.MaterialID);
            return View(uses);
        }

        // GET: Uses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uses uses = db.Uses.Find(id);
            if (uses == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "ProductDescription", uses.ProductID);
            ViewBag.MaterialID = new SelectList(db.RawMaterial, "MaterialID", "MaterialName", uses.MaterialID);
            return View(uses);
        }

        // POST: Uses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaterialID,ProductID")] Uses uses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "ProductDescription", uses.ProductID);
            ViewBag.MaterialID = new SelectList(db.RawMaterial, "MaterialID", "MaterialName", uses.MaterialID);
            return View(uses);
        }

        // GET: Uses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uses uses = db.Uses.Find(id);
            if (uses == null)
            {
                return HttpNotFound();
            }
            return View(uses);
        }

        // POST: Uses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uses uses = db.Uses.Find(id);
            db.Uses.Remove(uses);
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
