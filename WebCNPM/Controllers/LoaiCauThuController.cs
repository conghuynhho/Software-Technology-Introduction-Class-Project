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
    public class LoaiCauThuController : Controller
    {
        private MyModels db = new MyModels();

        // GET: LoaiCauThu
        public ActionResult Index()
        {
            return View(db.LOAICAUTHUs.ToList());
        }

        // GET: LoaiCauThu/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAICAUTHU lOAICAUTHU = db.LOAICAUTHUs.Find(id);
            if (lOAICAUTHU == null)
            {
                return HttpNotFound();
            }
            return View(lOAICAUTHU);
        }

        // GET: LoaiCauThu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiCauThu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiCauThu,LoaiCauThu1")] LOAICAUTHU lOAICAUTHU)
        {
            if (ModelState.IsValid)
            {
                db.LOAICAUTHUs.Add(lOAICAUTHU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAICAUTHU);
        }

        // GET: LoaiCauThu/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAICAUTHU lOAICAUTHU = db.LOAICAUTHUs.Find(id);
            if (lOAICAUTHU == null)
            {
                return HttpNotFound();
            }
            return View(lOAICAUTHU);
        }

        // POST: LoaiCauThu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiCauThu,LoaiCauThu1")] LOAICAUTHU lOAICAUTHU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAICAUTHU).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAICAUTHU);
        }

        // GET: LoaiCauThu/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAICAUTHU lOAICAUTHU = db.LOAICAUTHUs.Find(id);
            if (lOAICAUTHU == null)
            {
                return HttpNotFound();
            }
            return View(lOAICAUTHU);
        }

        // POST: LoaiCauThu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LOAICAUTHU lOAICAUTHU = db.LOAICAUTHUs.Find(id);
            db.LOAICAUTHUs.Remove(lOAICAUTHU);
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
