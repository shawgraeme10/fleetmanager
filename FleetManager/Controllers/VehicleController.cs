using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FleetManager.Models;
using FleetManager.Databases;

namespace FleetManager.Controllers
{
    public class VehicleController : Controller
    {
        private FleetContext db = new FleetContext();

        //
        // GET: /Vehicle/

        public ActionResult Index()
        {
            return View(db.vehicles.ToList());
        }

        //
        // GET: /Vehicle/Details/5

        public ActionResult Details(int id = 0)
        {
            Vehicle vehicle = db.vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vehicle/Create

        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicle);
        }

        //
        // GET: /Vehicle/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Vehicle vehicle = db.vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Edit/5

        [HttpPost]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Vehicle vehicle = db.vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.vehicles.Find(id);
            db.vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}