using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalExercise.Models;

namespace FinalExercise.Controllers
{
    public class sController : Controller
    {
        private StudentContext db = new StudentContext();

        // GET: s
        public ActionResult Index()
        {
            return View(db.ss.ToList());
        }

        // GET: s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            s s = db.ss.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // GET: s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SId,FirstName,LastName,CourseName")] s s)
        {
            if (ModelState.IsValid)
            {
                db.ss.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(s);
        }

        // GET: s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            s s = db.ss.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SId,FirstName,LastName,CourseName")] s s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }

        // GET: s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            s s = db.ss.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            s s = db.ss.Find(id);
            db.ss.Remove(s);
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
