using MVC_AE1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AE1.Controllers
{
    public class MoviesController : Controller
    {
        public static Movie movie = new Movie() { Name = "Shrek!", Rating = 5, DownloadURL = "#", ImageURL = @"https://rare-gallery.com/thumbs/582548-shrek.jpg" };
        public static List<Client> clients = new List<Client>()
        {
            new Client(){ Name = "Jane P.", MembershipCard = "1234", Address = "bul. Random Randomizer 69", Phone = "070223305", Age = 20},
            new Client(){ Name = "Johny B.", MembershipCard = "5678", Address = "bul. Weed club 420", Phone = "077777777", Age = 32},
            new Client(){ Name = "Pink P.", MembershipCard = "9100", Address = "bul. Children Generator 1", Phone = "070007007", Age = 15}
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = movie;
            return View(model);
        }

        public ActionResult ShowClient(int id)
        {
            return View(clients.ElementAt(id));
        }
    }
}