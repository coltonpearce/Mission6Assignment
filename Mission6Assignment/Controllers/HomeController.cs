using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6Assignment.Models;
using System.Diagnostics;

namespace Mission6Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AddMovieContext addMovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, AddMovieContext x)
        {
            _logger = logger;
            addMovieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewMovie ()
        {
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult myPodcasts()
        {
            return View("myPodcasts");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
