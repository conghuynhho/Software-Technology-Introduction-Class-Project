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
    public class CAUTHU_GHIBANController : Controller
    {
        private MyModels db = new MyModels();

        // GET: CAUTHU_GHIBAN
        public ActionResult Index()
        {
            var cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Include(c => c.BANTHANG).Include(c => c.CAUTHU).Include(c => c.TRANDAU);
            return View(cAUTHU_GHIBAN.ToList());
        }

        // GET: CAUTHU_GHIBAN/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            if (cAUTHU_GHIBAN == null)
            {
                return HttpNotFound();
            }
            return View(cAUTHU_GHIBAN);
        }

        // GET: CAUTHU_GHIBAN/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1");
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "TenCauThu");
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaTranDau");
            return View();
        }

        // POST: CAUTHU_GHIBAN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTGB,MaTranDau,MaCauThu,ThoiDiem,MaLoaiBanThang")] CAUTHU_GHIBAN cAUTHU_GHIBAN)
        {
            if (ModelState.IsValid)
            {
                db.CAUTHU_GHIBAN.Add(cAUTHU_GHIBAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1", cAUTHU_GHIBAN.MaLoaiBanThang);
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "MaDoi", cAUTHU_GHIBAN.MaCauThu);
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaMua", cAUTHU_GHIBAN.MaTranDau);
            return View(cAUTHU_GHIBAN);
        }

        // GET: CAUTHU_GHIBAN/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            if (cAUTHU_GHIBAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1", cAUTHU_GHIBAN.MaLoaiBanThang);
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "TenCauThu", cAUTHU_GHIBAN.MaCauThu);
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaTranDau", cAUTHU_GHIBAN.MaTranDau);
            return View(cAUTHU_GHIBAN);
        }

        // POST: CAUTHU_GHIBAN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTGB,MaTranDau,MaCauThu,ThoiDiem,MaLoaiBanThang")] CAUTHU_GHIBAN cAUTHU_GHIBAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAUTHU_GHIBAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1", cAUTHU_GHIBAN.MaLoaiBanThang);
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "MaDoi", cAUTHU_GHIBAN.MaCauThu);
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaMua", cAUTHU_GHIBAN.MaTranDau);
            return View(cAUTHU_GHIBAN);
        }

        // GET: CAUTHU_GHIBAN/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            if (cAUTHU_GHIBAN == null)
            {
                return HttpNotFound();
            }
            return View(cAUTHU_GHIBAN);
        }

        // POST: CAUTHU_GHIBAN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            db.CAUTHU_GHIBAN.Remove(cAUTHU_GHIBAN);
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
    public class KetQuaTranDauController : Controller
    {
        private MyModels db = new MyModels();

        // GET: CAUTHU_GHIBAN
        public ActionResult Index()
        {
            var cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Include(c => c.BANTHANG).Include(c => c.CAUTHU).Include(c => c.TRANDAU);
            return View(cAUTHU_GHIBAN.ToList());
        }

        // GET: CAUTHU_GHIBAN/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            if (cAUTHU_GHIBAN == null)
            {
                return HttpNotFound();
            }
            return View(cAUTHU_GHIBAN);
        }

        // GET: CAUTHU_GHIBAN/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1");
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "MaDoi");
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaMua");
            return View();
        }

        // POST: CAUTHU_GHIBAN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTGB,MaTranDau,MaCauThu,ThoiDiem,MaLoaiBanThang")] CAUTHU_GHIBAN cAUTHU_GHIBAN)
        {
            if (ModelState.IsValid)
            {
                db.CAUTHU_GHIBAN.Add(cAUTHU_GHIBAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1", cAUTHU_GHIBAN.MaLoaiBanThang);
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "MaDoi", cAUTHU_GHIBAN.MaCauThu);
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaMua", cAUTHU_GHIBAN.MaTranDau);
            return View(cAUTHU_GHIBAN);
        }

        // GET: CAUTHU_GHIBAN/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            if (cAUTHU_GHIBAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1", cAUTHU_GHIBAN.MaLoaiBanThang);
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "MaDoi", cAUTHU_GHIBAN.MaCauThu);
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaMua", cAUTHU_GHIBAN.MaTranDau);
            return View(cAUTHU_GHIBAN);
        }

        // POST: CAUTHU_GHIBAN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTGB,MaTranDau,MaCauThu,ThoiDiem,MaLoaiBanThang")] CAUTHU_GHIBAN cAUTHU_GHIBAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAUTHU_GHIBAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiBanThang = new SelectList(db.BANTHANGs, "MaLoaiBanThang", "BanThang1", cAUTHU_GHIBAN.MaLoaiBanThang);
            ViewBag.MaCauThu = new SelectList(db.CAUTHUs, "MaCauThu", "MaDoi", cAUTHU_GHIBAN.MaCauThu);
            ViewBag.MaTranDau = new SelectList(db.TRAUDAUs, "MaTranDau", "MaMua", cAUTHU_GHIBAN.MaTranDau);
            return View(cAUTHU_GHIBAN);
        }

        // GET: CAUTHU_GHIBAN/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            if (cAUTHU_GHIBAN == null)
            {
                return HttpNotFound();
            }
            return View(cAUTHU_GHIBAN);
        }

        // POST: CAUTHU_GHIBAN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CAUTHU_GHIBAN cAUTHU_GHIBAN = db.CAUTHU_GHIBAN.Find(id);
            db.CAUTHU_GHIBAN.Remove(cAUTHU_GHIBAN);
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
