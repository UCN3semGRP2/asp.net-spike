using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;

namespace MVC.Controllers
{
    public class LoanersController : Controller
    {
        private DALContext db = new DALContext();

        // GET: Loaners
        public ActionResult Index()
        {
            return View(db.Loaners.ToList());
        }

        // GET: Loaners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaner loaner = db.Loaners.Find(id);
            if (loaner == null)
            {
                return HttpNotFound();
            }
            return View(loaner);
        }

        // GET: Loaners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loaners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Loaner loaner)
        {
            if (ModelState.IsValid)
            {
                db.Loaners.Add(loaner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaner);
        }

        // GET: Loaners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaner loaner = db.Loaners.Find(id);
            if (loaner == null)
            {
                return HttpNotFound();
            }
            return View(loaner);
        }

        // POST: Loaners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Loaner loaner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaner);
        }

        // GET: Loaners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loaner loaner = db.Loaners.Find(id);
            if (loaner == null)
            {
                return HttpNotFound();
            }
            return View(loaner);
        }

        // POST: Loaners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Loaner loaner = db.Loaners.Find(id);
            db.Loaners.Remove(loaner);
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
