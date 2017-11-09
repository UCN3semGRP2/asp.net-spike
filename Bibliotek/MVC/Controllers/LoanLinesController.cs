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
    public class LoanLinesController : Controller
    {
        private DALContext db = new DALContext();

        // GET: LoanLines
        public ActionResult Index()
        {
            return View(db.LoanLines.ToList());
        }

        // GET: LoanLines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanLine loanLine = db.LoanLines.Find(id);

            if (loanLine == null)
            {
                return HttpNotFound();
            }
            return View(loanLine);
        }

        // GET: LoanLines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanLines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] LoanLine loanLine)
        {
            if (ModelState.IsValid)
            {
                db.LoanLines.Add(loanLine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanLine);
        }

        // GET: LoanLines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanLine loanLine = db.LoanLines.Find(id);
            if (loanLine == null)
            {
                return HttpNotFound();
            }
            return View(loanLine);
        }

        // POST: LoanLines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] LoanLine loanLine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanLine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanLine);
        }

        // GET: LoanLines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanLine loanLine = db.LoanLines.Find(id);
            if (loanLine == null)
            {
                return HttpNotFound();
            }
            return View(loanLine);
        }

        // POST: LoanLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanLine loanLine = db.LoanLines.Find(id);
            db.LoanLines.Remove(loanLine);
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
