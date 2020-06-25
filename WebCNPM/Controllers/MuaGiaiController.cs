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
    public class MuaGiaiController : Controller
    {
        private MyModels db = new MyModels();

        // GET: MuaGiai
        public ActionResult Index()
        {
            return View(db.MUAGIAIs.ToList());
        }

        // GET: MuaGiai/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUAGIAI mUAGIAI = db.MUAGIAIs.Find(id);
            if (mUAGIAI == null)
            {
                return HttpNotFound();
            }
            return View(mUAGIAI);
        }

        // GET: MuaGiai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MuaGiai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaMua,TenMua,NgayBatDau,NgayKetThuc")] MUAGIAI mUAGIAI)
        {
            if (ModelState.IsValid)
            {
                db.MUAGIAIs.Add(mUAGIAI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mUAGIAI);
        }

        // GET: MuaGiai/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUAGIAI mUAGIAI = db.MUAGIAIs.Find(id);
            if (mUAGIAI == null)
            {
                return HttpNotFound();
            }
            return View(mUAGIAI);
        }

        // POST: MuaGiai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaMua,TenMua,NgayBatDau,NgayKetThuc")] MUAGIAI mUAGIAI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mUAGIAI).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mUAGIAI);
        }

        // GET: MuaGiai/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MUAGIAI mUAGIAI = db.MUAGIAIs.Find(id);
            if (mUAGIAI == null)
            {
                return HttpNotFound();
            }
            return View(mUAGIAI);
        }

        // POST: MuaGiai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MUAGIAI mUAGIAI = db.MUAGIAIs.Find(id);
            db.MUAGIAIs.Remove(mUAGIAI);
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
