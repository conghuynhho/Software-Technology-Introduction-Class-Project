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
    public class TranDauController : Controller
    {
        private MyModels db = new MyModels();

        // GET: TranDau
        public ActionResult Index()
        {
            var tRAUDAUs = db.TRAUDAUs.Include(t => t.MUAGIAI).Include(t => t.TRONGTAI);
            return View(tRAUDAUs.ToList());
        }

        // GET: TranDau/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            if (tRAUDAU == null)
            {
                return HttpNotFound();
            }
            return View(tRAUDAU);
        }

        // GET: TranDau/Create
        public ActionResult Create()
        {
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua");
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai");
            return View();
        }

        // POST: TranDau/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTranDau,MaMua,MaDoi1,MaDoi2,Luot,MaSan,MaTrongTai,Ngay,gio,SoBanThangDoi1,SoBanThangDoi2")] TRAUDAU tRAUDAU)
        {
            if (ModelState.IsValid)
            {
                db.TRAUDAUs.Add(tRAUDAU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", tRAUDAU.MaMua);
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai", tRAUDAU.MaTrongTai);
            return View(tRAUDAU);
        }

        // GET: TranDau/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            if (tRAUDAU == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", tRAUDAU.MaMua);
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai", tRAUDAU.MaTrongTai);
            return View(tRAUDAU);
        }

        // POST: TranDau/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTranDau,MaMua,MaDoi1,MaDoi2,Luot,MaSan,MaTrongTai,Ngay,gio,SoBanThangDoi1,SoBanThangDoi2")] TRAUDAU tRAUDAU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRAUDAU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", tRAUDAU.MaMua);
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai", tRAUDAU.MaTrongTai);
            return View(tRAUDAU);
        }

        // GET: TranDau/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            if (tRAUDAU == null)
            {
                return HttpNotFound();
            }
            return View(tRAUDAU);
        }

        // POST: TranDau/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            db.TRAUDAUs.Remove(tRAUDAU);
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
    public class LichThiDauController : Controller
    {
        private MyModels db = new MyModels();

        // GET: TranDau
        public ActionResult Index()
        {
            var tRAUDAUs = db.TRAUDAUs.Include(t => t.MUAGIAI).Include(t => t.TRONGTAI);
            return View(tRAUDAUs.ToList());
        }

        // GET: TranDau/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            if (tRAUDAU == null)
            {
                return HttpNotFound();
            }
            return View(tRAUDAU);
        }

        // GET: TranDau/Create
        public ActionResult Create()
        {
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua");
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai");
            return View();
        }

        // POST: TranDau/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTranDau,MaMua,MaDoi1,MaDoi2,Luot,MaSan,MaTrongTai,Ngay,gio,SoBanThangDoi1,SoBanThangDoi2")] TRAUDAU tRAUDAU)
        {
            if (ModelState.IsValid)
            {
                db.TRAUDAUs.Add(tRAUDAU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", tRAUDAU.MaMua);
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai", tRAUDAU.MaTrongTai);
            return View(tRAUDAU);
        }

        // GET: TranDau/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            if (tRAUDAU == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", tRAUDAU.MaMua);
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai", tRAUDAU.MaTrongTai);
            return View(tRAUDAU);
        }

        // POST: TranDau/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTranDau,MaMua,MaDoi1,MaDoi2,Luot,MaSan,MaTrongTai,Ngay,gio,SoBanThangDoi1,SoBanThangDoi2")] TRAUDAU tRAUDAU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRAUDAU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaMua = new SelectList(db.MUAGIAIs, "MaMua", "TenMua", tRAUDAU.MaMua);
            ViewBag.MaTrongTai = new SelectList(db.TRONGTAIs, "MaTrongTai", "TenTrongTai", tRAUDAU.MaTrongTai);
            return View(tRAUDAU);
        }

        // GET: TranDau/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            if (tRAUDAU == null)
            {
                return HttpNotFound();
            }
            return View(tRAUDAU);
        }

        // POST: TranDau/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRAUDAU tRAUDAU = db.TRAUDAUs.Find(id);
            db.TRAUDAUs.Remove(tRAUDAU);
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
