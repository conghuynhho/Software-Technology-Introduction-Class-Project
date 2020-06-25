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
    public class BanThangController : Controller
    {
        private MyModels db = new MyModels();

        // GET: BanThang
        public ActionResult Index()
        {
            return View(db.BANTHANGs.ToList());
        }

        // GET: BanThang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BANTHANG bANTHANG = db.BANTHANGs.Find(id);
            if (bANTHANG == null)
            {
                return HttpNotFound();
            }
            return View(bANTHANG);
        }

        // GET: BanThang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BanThang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiBanThang,BanThang1")] BANTHANG bANTHANG)
        {
            if (ModelState.IsValid)
            {
                db.BANTHANGs.Add(bANTHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bANTHANG);
        }

        // GET: BanThang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BANTHANG bANTHANG = db.BANTHANGs.Find(id);
            if (bANTHANG == null)
            {
                return HttpNotFound();
            }
            return View(bANTHANG);
        }

        // POST: BanThang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiBanThang,BanThang1")] BANTHANG bANTHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bANTHANG).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bANTHANG);
        }

        // GET: BanThang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BANTHANG bANTHANG = db.BANTHANGs.Find(id);
            if (bANTHANG == null)
            {
                return HttpNotFound();
            }
            return View(bANTHANG);
        }

        // POST: BanThang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BANTHANG bANTHANG = db.BANTHANGs.Find(id);
            db.BANTHANGs.Remove(bANTHANG);
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
