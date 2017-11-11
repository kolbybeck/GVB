using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GVB.DAL;
using GVB.Models;

namespace GVB.Controllers
{
    [Authorize]
    public class CattleTypeController : Controller
    {
        private GVBDBContext db = new GVBDBContext();

        // GET: CattleTypes
        public ActionResult Index()
        {
            return View(db.CattleType.ToList());
        }

        // GET: CattleTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CattleType cattleType = db.CattleType.Find(id);
            if (cattleType == null)
            {
                return HttpNotFound();
            }
            return View(cattleType);
        }

        // GET: CattleTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CattleTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CattleTypeID,CattleTypeDesc")] CattleType cattleType)
        {
            if (ModelState.IsValid)
            {
                db.CattleType.Add(cattleType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cattleType);
        }

        // GET: CattleTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CattleType cattleType = db.CattleType.Find(id);
            if (cattleType == null)
            {
                return HttpNotFound();
            }
            return View(cattleType);
        }

        // POST: CattleTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CattleTypeID,CattleTypeDesc")] CattleType cattleType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cattleType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cattleType);
        }

        // GET: CattleTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CattleType cattleType = db.CattleType.Find(id);
            if (cattleType == null)
            {
                return HttpNotFound();
            }
            return View(cattleType);
        }

        // POST: CattleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CattleType cattleType = db.CattleType.Find(id);
            db.CattleType.Remove(cattleType);
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
