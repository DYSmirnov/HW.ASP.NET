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
    public class StudentModelsController : Controller
    {
        private StudentContext db = new StudentContext();


        [HttpPost]
       public ViewResult SUM(Models.StudentModels st)
        {
            int s = st.PointSum();
            ViewBag.Sum = s;
            return View("Ss");
        }
        

        // GET: StudentModels
        public ActionResult Index()
        {
            
            ViewBag.St = db.Students.ToList();
            return View(db.Students.ToList());
        }

        // GET: StudentModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModels studentModels = db.Students.Find(id);
            if (studentModels == null)
            {
                return HttpNotFound();
            }
            return View(studentModels);
        }

        // GET: StudentModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentModelsId,FirstName,LastName,CourseName,point1,point2,point3,point4,point5,point6,point7,point8,point9,point10")] StudentModels studentModels)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(studentModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentModels);
        }

        // GET: StudentModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModels studentModels = db.Students.Find(id);
            if (studentModels == null)
            {
                return HttpNotFound();
            }
            return View(studentModels);
        }

        // POST: StudentModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentModelsId,FirstName,LastName,CourseName,point1,point2,point3,point4,point5,point6,point7,point8,point9,point10")] StudentModels studentModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentModels);
        }

        // GET: StudentModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModels studentModels = db.Students.Find(id);
            if (studentModels == null)
            {
                return HttpNotFound();
            }
            return View(studentModels);
        }

        // POST: StudentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentModels studentModels = db.Students.Find(id);
            db.Students.Remove(studentModels);
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
