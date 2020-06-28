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
    public class DoiBongController : Controller
    {
        MyModels db = new MyModels();

        // GET: DoiBong
        public ActionResult SaveHoSo(string madoi, string tendoi, string masan, CAUTHU[] order)
        {
            string result = "Error! Your Request Is Not Complete!";
            if (madoi != null && tendoi != null && masan != null && order != null)
            {
                /*var cutomerId = Guid.NewGuid();*/
                DOIBONG model = new DOIBONG();
                model.MaDoi = madoi;
                model.TenDoi = tendoi;
                model.MaSan = masan;
                /*model.OrderDate = DateTime.Now;*/
                db.DOIBONGs.Add(model);

                foreach (var item in order)
                {
                    /*var orderId = Guid.NewGuid();*/
                    CAUTHU O = new CAUTHU();
                    O.MaCauThu = item.MaCauThu;
                    O.MaDoi = madoi;
                    O.TenCauThu = item.TenCauThu;
                    O.NgaySinh = item.NgaySinh;
                    O.MaLoaiCauThu = item.MaLoaiCauThu;
                    O.QuocTich = item.QuocTich;
                    O.GhiChu = item.GhiChu;
                    O.HinhAnh = item.HinhAnh;
                    db.CAUTHUs.Add(O);
                }
                db.SaveChanges();
                result = "Success! Add Complete!";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MyIndex()
        {
            var List_CauThu = db.DOIBONGs.Include(a => a.SAN);
            return View(List_CauThu);
        }
        
        public ActionResult Index()
        {
            var dOIBONGs = db.DOIBONGs.Include(d => d.SAN);

            return View(dOIBONGs.ToList());
        }

        // GET: DoiBong/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOIBONG dOIBONG = db.DOIBONGs.Find(id);
            if (dOIBONG == null)
            {
                return HttpNotFound();
            }
            return View(dOIBONG);
        }

        // GET: DoiBong/Create
        public ActionResult Create()
        {
            ViewBag.MaSan = new SelectList(db.SANs, "MaSan", "TenSan");
            return View();
        }

        // POST: DoiBong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDoi,TenDoi,MaSan,NgayThanhLap")] DOIBONG dOIBONG)
        {
            if (ModelState.IsValid)
            {
                db.DOIBONGs.Add(dOIBONG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSan = new SelectList(db.SANs, "MaSan", "TenSan", dOIBONG.MaSan);
            return View(dOIBONG);
        }

        // GET: DoiBong/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOIBONG dOIBONG = db.DOIBONGs.Find(id);
            if (dOIBONG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSan = new SelectList(db.SANs, "MaSan", "TenSan", dOIBONG.MaSan);
            return View(dOIBONG);
        }

        // POST: DoiBong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDoi,TenDoi,MaSan,NgayThanhLap")] DOIBONG dOIBONG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dOIBONG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSan = new SelectList(db.SANs, "MaSan", "TenSan", dOIBONG.MaSan);
            return View(dOIBONG);
        }

        // GET: DoiBong/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOIBONG dOIBONG = db.DOIBONGs.Find(id);
            if (dOIBONG == null)
            {
                return HttpNotFound();
            }
            return View(dOIBONG);
        }

        // POST: DoiBong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DOIBONG dOIBONG = db.DOIBONGs.Find(id);
            db.DOIBONGs.Remove(dOIBONG);
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
