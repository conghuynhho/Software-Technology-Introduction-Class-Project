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
    public class TrongTaiController : Controller
    {
        private MyModels db = new MyModels();

        // GET: TrongTai
        public ActionResult Index()
        {
            return View(db.TRONGTAIs.ToList());
        }

        // GET: TrongTai/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRONGTAI tRONGTAI = db.TRONGTAIs.Find(id);
            if (tRONGTAI == null)
            {
                return HttpNotFound();
            }
            return View(tRONGTAI);
        }

        // GET: TrongTai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrongTai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTrongTai,TenTrongTai,QuocTich")] TRONGTAI tRONGTAI)
        {
            if (ModelState.IsValid)
            {
                db.TRONGTAIs.Add(tRONGTAI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRONGTAI);
        }

        // GET: TrongTai/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRONGTAI tRONGTAI = db.TRONGTAIs.Find(id);
            if (tRONGTAI == null)
            {
                return HttpNotFound();
            }
            return View(tRONGTAI);
        }

        // POST: TrongTai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTrongTai,TenTrongTai,QuocTich")] TRONGTAI tRONGTAI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRONGTAI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRONGTAI);
        }

        // GET: TrongTai/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRONGTAI tRONGTAI = db.TRONGTAIs.Find(id);
            if (tRONGTAI == null)
            {
                return HttpNotFound();
            }
            return View(tRONGTAI);
        }

        // POST: TrongTai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRONGTAI tRONGTAI = db.TRONGTAIs.Find(id);
            db.TRONGTAIs.Remove(tRONGTAI);
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
