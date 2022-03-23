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
    public class SClassesController : Controller
    {
        private StudentContext db = new StudentContext();

        public ActionResult TopSC()
        {
            var res = (from ssc in db.Sc
                       group ssc by new
                       {
                           ssc.Name
                       }
                       into sum
                           orderby sum.Key.Name
                           select new ResModel
                           {
                               ResName = sum.Key.Name,
                               ResRes = sum.Sum(x => x.Point)
                           });
            var top = (from i in res
                       orderby i.ResRes descending
                       select i).Take(2);
            ViewBag.Top = top;

            var bad = (from i in res
                       orderby i.ResRes 
                       select i).Take(2);

            ViewBag.Bad = bad;


            return View();
        }




        public ActionResult SumSC()
        {

            var res = (from ssc in db.Sc
                       group ssc by new
                       {
                           ssc.Name
                       }
                      into sum
                       orderby sum.Key.Name
                       select new ResModel
                       {
                           ResName = sum.Key.Name,
                           ResRes = sum.Sum(x => x.Point)
                       });

            

            var bad = (from i in res
                       orderby i.ResRes descending
                       select i).Take(2);

            ViewBag.Bad = bad;

            ViewBag.Res = res.ToList();
            return View();
        }

        // GET: SClasses
        public ActionResult Index()
        {
            return View(db.Sc.ToList());
        }

        // GET: SClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SClass sClass = db.Sc.Find(id);
            if (sClass == null)
            {
                return HttpNotFound();
            }
            return View(sClass);
        }

        // GET: SClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SClassId,Name,CourseName,Point")] SClass sClass)
        {
            if (ModelState.IsValid)
            {
                db.Sc.Add(sClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sClass);
        }

        // GET: SClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SClass sClass = db.Sc.Find(id);
            if (sClass == null)
            {
                return HttpNotFound();
            }
            return View(sClass);
        }

        // POST: SClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SClassId,Name,CourseName,Point")] SClass sClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sClass);
        }

        // GET: SClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SClass sClass = db.Sc.Find(id);
            if (sClass == null)
            {
                return HttpNotFound();
            }
            return View(sClass);
        }

        // POST: SClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SClass sClass = db.Sc.Find(id);
            db.Sc.Remove(sClass);
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
