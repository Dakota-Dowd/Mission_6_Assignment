using Microsoft.AspNetCore.Mvc;
using Mission_6_Assignment.Models;

namespace Mission_6_Assignment.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Entry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entry(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(movie);
        }
    }
}
