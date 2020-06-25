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
    public class TraCuuCauThuController : Controller
    {
        private MyModels db = new MyModels();

        // GET: TraCuuCauThu
        public ActionResult Index(string searchCauThu)
        {
            var cauthus = from s in db.CAUTHUs
                        select s;
            if (!String.IsNullOrEmpty(searchCauThu))
            {
                cauthus = cauthus.Where(s => s.TenCauThu.Contains(searchCauThu));
            }    
            return View(cauthus.ToList());
        }

        // GET: TraCuuCauThu/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU cAUTHU = db.CAUTHUs.Find(id);
            if (cAUTHU == null)
            {
                return HttpNotFound();
            }
            return View(cAUTHU);
        }

        // GET: TraCuuCauThu/Create
        public ActionResult Create()
        {
            ViewBag.MaDoi = new SelectList(db.DOIBONGs, "MaDoi", "TenDoi");
            ViewBag.MaLoaiCauThu = new SelectList(db.LOAICAUTHUs, "MaLoaiCauThu", "LoaiCauThu1");
            return View();
        }

        // POST: TraCuuCauThu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCauThu,MaDoi,TenCauThu,NgaySinh,MaLoaiCauThu,QuocTich,GhiChu,HinhAnh")] CAUTHU cAUTHU)
        {
            if (ModelState.IsValid)
            {
                db.CAUTHUs.Add(cAUTHU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDoi = new SelectList(db.DOIBONGs, "MaDoi", "TenDoi", cAUTHU.MaDoi);
            ViewBag.MaLoaiCauThu = new SelectList(db.LOAICAUTHUs, "MaLoaiCauThu", "LoaiCauThu1", cAUTHU.MaLoaiCauThu);
            return View(cAUTHU);
        }

        // GET: TraCuuCauThu/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU cAUTHU = db.CAUTHUs.Find(id);
            if (cAUTHU == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDoi = new SelectList(db.DOIBONGs, "MaDoi", "TenDoi", cAUTHU.MaDoi);
            ViewBag.MaLoaiCauThu = new SelectList(db.LOAICAUTHUs, "MaLoaiCauThu", "LoaiCauThu1", cAUTHU.MaLoaiCauThu);
            return View(cAUTHU);
        }

        // POST: TraCuuCauThu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCauThu,MaDoi,TenCauThu,NgaySinh,MaLoaiCauThu,QuocTich,GhiChu,HinhAnh")] CAUTHU cAUTHU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cAUTHU).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDoi = new SelectList(db.DOIBONGs, "MaDoi", "TenDoi", cAUTHU.MaDoi);
            ViewBag.MaLoaiCauThu = new SelectList(db.LOAICAUTHUs, "MaLoaiCauThu", "LoaiCauThu1", cAUTHU.MaLoaiCauThu);
            return View(cAUTHU);
        }

        // GET: TraCuuCauThu/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CAUTHU cAUTHU = db.CAUTHUs.Find(id);
            if (cAUTHU == null)
            {
                return HttpNotFound();
            }
            return View(cAUTHU);
        }

        // POST: TraCuuCauThu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CAUTHU cAUTHU = db.CAUTHUs.Find(id);
            db.CAUTHUs.Remove(cAUTHU);
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
