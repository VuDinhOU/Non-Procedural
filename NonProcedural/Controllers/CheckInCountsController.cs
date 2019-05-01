using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NonProcedural.Models;

namespace NonProcedural.Controllers
{
    public class CheckInCountsController : Controller
    {
        private CCLogEntities1 db = new CCLogEntities1();

        // GET: CheckInCounts
        public ActionResult Index()
        {
            return View(db.CheckInCounts.ToList());
        }

        // GET: CheckInCounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckInCount checkInCount = db.CheckInCounts.Find(id);
            if (checkInCount == null)
            {
                return HttpNotFound();
            }
            return View(checkInCount);
        }

        // GET: CheckInCounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckInCounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,FirstName,LastName,HPNumber,Email,CheckInDay")] CheckInCount checkInCount)
        {
            if (ModelState.IsValid)
            {
                db.CheckInCounts.Add(checkInCount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(checkInCount);
        }

        // GET: CheckInCounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckInCount checkInCount = db.CheckInCounts.Find(id);
            if (checkInCount == null)
            {
                return HttpNotFound();
            }
            return View(checkInCount);
        }

        // POST: CheckInCounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,FirstName,LastName,HPNumber,Email,CheckInDay")] CheckInCount checkInCount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkInCount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(checkInCount);
        }

        // GET: CheckInCounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckInCount checkInCount = db.CheckInCounts.Find(id);
            if (checkInCount == null)
            {
                return HttpNotFound();
            }
            return View(checkInCount);
        }

        // POST: CheckInCounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CheckInCount checkInCount = db.CheckInCounts.Find(id);
            db.CheckInCounts.Remove(checkInCount);
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
