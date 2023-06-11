using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoServiceWebApp.Models;

namespace AutoServiceWebApp.Controllers
{
    [Authorize(Roles = "Administrator,User")]
    public class AutoServicesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Authorize(Roles = "Administrator")]
        public ActionResult AddCar(int id)
        {
            CarAutoService model = new CarAutoService();
            model.AutoServiceId = id;
            model.service = db.Services.Find(id);
            model.cars = db.Cars.ToList();
            return View(model);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult AddCar(CarAutoService model)
        {
            var autoservice = db.Services.Find(model.AutoServiceId);
            var car = db.Cars.Find(model.CarId);

            autoservice.cars.Add(car);
            db.SaveChanges();

            return RedirectToAction("Details", new { id = model.AutoServiceId });
        }

        // GET: AutoServices
        [Authorize(Roles = "Administrator,User")]
        public ActionResult Index()
        {
            return View(db.Services.ToList());
        }

        // GET: AutoServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AutoService autoService = db.Services.Find(id);
            if (autoService == null)
            {
                return HttpNotFound();
            }
            return View(autoService);
        }

        // GET: AutoServices/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Capacity")] AutoService autoService)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(autoService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autoService);
        }

        // GET: AutoServices/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AutoService autoService = db.Services.Find(id);
            if (autoService == null)
            {
                return HttpNotFound();
            }
            return View(autoService);
        }

        // POST: AutoServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Capacity")] AutoService autoService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autoService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autoService);
        }

        // GET: AutoServices/Delete/5
        /*
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AutoService autoService = db.Services.Find(id);
            if (autoService == null)
            {
                return HttpNotFound();
            }
            return View(autoService);
        }
        */
        // POST: AutoServices/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int id)
        {
            AutoService autoService = db.Services.Find(id);
            db.Services.Remove(autoService);
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
