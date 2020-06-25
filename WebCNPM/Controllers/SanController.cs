using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebCNPM.Models;

namespace WebCNPM.Controllers
{
    public class SanController : Controller
    {
        private MyModels db = new MyModels();

        // GET: San
        public ActionResult Index()
        {
            return View(db.SANs.ToList());
        }

        // GET: San/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAN sAN = db.SANs.Find(id);
            if (sAN == null)
            {
                return HttpNotFound();
            }
            return View(sAN);
        }

        // GET: San/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: San/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSan,TenSan,Diachi")] SAN sAN)
        {
            if (ModelState.IsValid)
            {
                db.SANs.Add(sAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sAN);
        }

        // GET: San/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAN sAN = db.SANs.Find(id);
            if (sAN == null)
            {
                return HttpNotFound();
            }
            return View(sAN);
        }

        // POST: San/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSan,TenSan,Diachi")] SAN sAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sAN);
        }

        // GET: San/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAN sAN = db.SANs.Find(id);
            if (sAN == null)
            {
                return HttpNotFound();
            }
            return View(sAN);
        }

        // POST: San/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SAN sAN = db.SANs.Find(id);
            db.SANs.Remove(sAN);
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
