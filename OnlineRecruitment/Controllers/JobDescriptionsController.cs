using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineRecruitment.Models;

namespace OnlineRecruitment.Controllers
{
    public class JobDescriptionsController : Controller
    {
        private recruitmentEntities1 db = new recruitmentEntities1();

        // GET: JobDescriptions
        public ActionResult Index()
        {
            return View(db.JobDescriptions.ToList());
        }

        // GET: JobDescriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDescription jobDescription = db.JobDescriptions.Find(id);
            if (jobDescription == null)
            {
                return HttpNotFound();
            }
            return View(jobDescription);
        }

        // GET: JobDescriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobDescriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobId,Role,Salary,Skills,Location,Type")] JobDescription jobDescription)
        {
            if (ModelState.IsValid)
            {
                db.JobDescriptions.Add(jobDescription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobDescription);
        }

        // GET: JobDescriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDescription jobDescription = db.JobDescriptions.Find(id);
            if (jobDescription == null)
            {
                return HttpNotFound();
            }
            return View(jobDescription);
        }

        // POST: JobDescriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobId,Role,Salary,Skills,Location,Type")] JobDescription jobDescription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobDescription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobDescription);
        }

        // GET: JobDescriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDescription jobDescription = db.JobDescriptions.Find(id);
            if (jobDescription == null)
            {
                return HttpNotFound();
            }
            return View(jobDescription);
        }

        // POST: JobDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobDescription jobDescription = db.JobDescriptions.Find(id);
            db.JobDescriptions.Remove(jobDescription);
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
