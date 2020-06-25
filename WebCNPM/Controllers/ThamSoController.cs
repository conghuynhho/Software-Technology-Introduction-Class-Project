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
    public class ThamSoController : Controller
    {
        private MyModels db = new MyModels();

        // GET: ThamSo
        public ActionResult Index()
        {
            return View(db.THAMSOes.ToList());
        }

        // GET: ThamSo/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THAMSO tHAMSO = db.THAMSOes.Find(id);
            if (tHAMSO == null)
            {
                return HttpNotFound();
            }
            return View(tHAMSO);
        }

        // GET: ThamSo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThamSo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTS,TuoiTT,TuoiTD,SoCauThuTT,SoCauThuTD,SoCauThuNgoaiTD,ThoiDiemTT,ThoiDiemTD,DiemThang,DiemHoa,DiemThua")] THAMSO tHAMSO)
        {
            if (ModelState.IsValid)
            {
                db.THAMSOes.Add(tHAMSO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tHAMSO);
        }

        // GET: ThamSo/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THAMSO tHAMSO = db.THAMSOes.Find(id);
            if (tHAMSO == null)
            {
                return HttpNotFound();
            }
            return View(tHAMSO);
        }

        // POST: ThamSo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTS,TuoiTT,TuoiTD,SoCauThuTT,SoCauThuTD,SoCauThuNgoaiTD,ThoiDiemTT,ThoiDiemTD,DiemThang,DiemHoa,DiemThua")] THAMSO tHAMSO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHAMSO).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tHAMSO);
        }

        // GET: ThamSo/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THAMSO tHAMSO = db.THAMSOes.Find(id);
            if (tHAMSO == null)
            {
                return HttpNotFound();
            }
            return View(tHAMSO);
        }

        // POST: ThamSo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            THAMSO tHAMSO = db.THAMSOes.Find(id);
            db.THAMSOes.Remove(tHAMSO);
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
