using BackendPart.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendPart.Controllers
{
    public class HomeController : Controller
    {
        CinemaContext context = new CinemaContext();
        
        public ActionResult Index()
        {
            ViewBag.Movie = context.Movies;
            return View();
        }

        public ActionResult AddMovie(string name, DateTime time)
        {
            context.Movies.Add(new Movie(){ Name = name, StarOfShow = time });
            context.SaveChanges();
            ViewBag.Movie = context.Movies;
            return View();
        }

        public ActionResult Delete(int id)
        {
            Movie movie = context.Movies.Include(g => g.SoldTickets).FirstOrDefault(g => g.Id == id);
            context.Movies.Remove(movie);
            context.SaveChanges();
            ViewBag.Movie = context.Movies;
            return View("AddMovie");
        }

        public ActionResult GetSales(int id)
        {
            ViewBag.Selected = context.Movies.Where(g => g.Id == id).Include(g => g.SoldTickets).FirstOrDefault();
            return View();
        }

        public void AddTicket(int id, int count)
        {
            var t = context.Movies.FirstOrDefault(g => g.Id == id);
            t.SoldTickets.Add(new Ticket() { QuantitySold = count, SalesTime = DateTime.Now });
            context.SaveChanges();
        }
    }
}
