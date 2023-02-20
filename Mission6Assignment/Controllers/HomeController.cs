using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6Assignment.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Assignment.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieContext addMovieContext { get; set; }

        public HomeController(AddMovieContext x)
        {
            addMovieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewMovie ()
        {
            ViewBag.Category = addMovieContext.Categories.ToList();

            return View("NewMovie");
        }

        //this is where I will use the POST method to save my data to a database
        [HttpPost]
        public IActionResult AddNewMovie(NewMovie nm)
        {
            if(ModelState.IsValid)
            {
                addMovieContext.Add(nm);
                addMovieContext.SaveChanges();
                return View("confirmation", nm);
            }
            else
            {
                return View();
            }
        }

        //this is creating a list of the possible choices that a person can select
        public IActionResult List()
        {
            var movies = addMovieContext.newMovies
                .Include(x => x.Category)
                .OrderBy(x => x.MovieTitle)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Category = addMovieContext.Categories.ToList();

            var movie = addMovieContext.newMovies.Single(x => x.MovieID == movieid);

            return View("NewMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(NewMovie nm)
        {
            if (ModelState.IsValid)
            {
                addMovieContext.Update(nm);
                addMovieContext.SaveChanges();
                return RedirectToAction("list"); 
            }
            else //if entries are invalid
            {
                return View(nm);
            }
            
        }


        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = addMovieContext.newMovies.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(NewMovie nm)
        {
            addMovieContext.newMovies.Remove(nm);
            addMovieContext.SaveChanges();

            return RedirectToAction("list");
        }
    }
}
