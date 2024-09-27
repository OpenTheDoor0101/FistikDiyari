using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IntProg2Odev2.Models;

namespace IntProg2Odev2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UretimGrafigisAdminController : Controller
    {
        private findikDbContext db = new findikDbContext();

        // GET: UretimGrafigisAdmin
        public ActionResult Index()
        {
            return View(db.UretimGrafigi.ToList());
        }

        // GET: UretimGrafigisAdmin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UretimGrafigi uretimGrafigi = db.UretimGrafigi.Find(id);
            if (uretimGrafigi == null)
            {
                return HttpNotFound();
            }
            return View(uretimGrafigi);
        }

        // GET: UretimGrafigisAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UretimGrafigisAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SehirAdi,UretimMiktari2017,UretimMiktari2018,UretimMiktari2019,UretimMiktari2020,UretimMiktari2021,UretimMiktari2022")] UretimGrafigi uretimGrafigi)
        {
            if (ModelState.IsValid)
            {
                db.UretimGrafigi.Add(uretimGrafigi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uretimGrafigi);
        }

        // GET: UretimGrafigisAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UretimGrafigi uretimGrafigi = db.UretimGrafigi.Find(id);
            if (uretimGrafigi == null)
            {
                return HttpNotFound();
            }
            return View(uretimGrafigi);
        }

        // POST: UretimGrafigisAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SehirAdi,UretimMiktari2017,UretimMiktari2018,UretimMiktari2019,UretimMiktari2020,UretimMiktari2021,UretimMiktari2022")] UretimGrafigi uretimGrafigi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uretimGrafigi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uretimGrafigi);
        }

        // GET: UretimGrafigisAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UretimGrafigi uretimGrafigi = db.UretimGrafigi.Find(id);
            if (uretimGrafigi == null)
            {
                return HttpNotFound();
            }
            return View(uretimGrafigi);
        }

        // POST: UretimGrafigisAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UretimGrafigi uretimGrafigi = db.UretimGrafigi.Find(id);
            db.UretimGrafigi.Remove(uretimGrafigi);
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
