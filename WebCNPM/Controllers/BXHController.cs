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
    public class BXHController : Controller
    {
        private MyModels db = new MyModels();

        // GET: BXH
        public ActionResult Index()
        {
            var bXHs = db.BXHs.Include(b => b.MUAGIAI);
            return View(bXHs.ToList());
        }

        // GET: BXH/Details/5
        public ActionResult Details(string id , string idd)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            BXH bXH = db.BXHs.Find(id,idd);
            if (bXH == null)
            {
                return HttpNotFound();
            }
            return View(bXH);
        }

        // GET: BXH/Create
        public ActionResult Create()
        {
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua");
            return View();
        }

        // POST: BXH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDoi,MaMua,TongHieuSo,SoTranThang,SoTranThua,SoTranHoa,BanThangSanKhach")] BXH bXH)
        {
            if (ModelState.IsValid)
            {
                db.BXHs.Add(bXH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", bXH.MaMua);
            return View(bXH);
        }

        // GET: BXH/Edit/5
        public ActionResult Edit(string id,string idd)
        {
            if (id == null || idd == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BXH bXH = db.BXHs.Find(id,idd);
            if (bXH == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", bXH.MaMua);
            return View(bXH);
        }

        // POST: BXH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDoi,MaMua,TongHieuSo,SoTranThang,SoTranThua,SoTranHoa,BanThangSanKhach")] BXH bXH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bXH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", bXH.MaMua);
            return View(bXH);
        }

        // GET: BXH/Delete/5
        public ActionResult Delete(string id, string idd)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            BXH bXH = db.BXHs.Find(id,idd);
            if (bXH == null)
            {
                return HttpNotFound();
            }
            return View(bXH);
        }

        // POST: BXH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id ,string idd)
        {
            
            BXH bXH = db.BXHs.Find(id,idd);
            db.BXHs.Remove(bXH);
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
