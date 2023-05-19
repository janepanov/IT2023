using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_AE3_EF.Models;

namespace MVC_AE3_EF.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "Admin,Editor")]
    [Authorize(Roles = "Admin,Editor,User")]
    public class MoviesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //Custom actions
        [Authorize(Roles = "Admin")]
        public ActionResult InsertNewClient(int id)
        {
            ClientMovie model = new ClientMovie();
            model.MovieId = id;
            model.movie = db.Movies.Find(id);
            model.clients = db.Clients.ToList();

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult InsertNewClient(ClientMovie model)
        {
            var client = db.Clients.Find(model.ClientId);
            //var client = db.Clients.Where(c => c.ClientId == model.ClientId).FirstOrDefault();

            var movie = db.Movies.Find(model.MovieId);
            movie.clients.Add(client);
            db.SaveChanges();

            return View("Index", db.Movies.ToList());
        }

        // GET: Movies
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Movies/Details/5
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "MovieId,Name,Rating,DownloadURL,ImageURL")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Edit/5
        //[Authorize(Roles = "Administrator")]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Edit([Bind(Include = "MovieId,Name,Rating,DownloadURL,ImageURL")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
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