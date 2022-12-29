using FilmTanitim.Data;
using FilmTanitim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTanitim.Areas.Users.Controllers
{
    [Area("Users")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult CategoryDetails(int? id)
        {
            var movies = _context.Movie.Where(x => x.CategoryId == id).ToList();
            ViewBag.KategoriId = id;
            ViewBag.KategoriAd = _context.Category.FirstOrDefault(x => x.CategoryId == id).CategoryName;
            return View(movies);
        }
        public IActionResult Index()
        {
            var filmListesi = _context.Movie.ToList();
            return View(filmListesi);
        }
        public async Task<IActionResult> Details(int? id)
        {
            var movie = await _context.Movie
                .Include(m => m.Category).Include(x=>x.Comment)
                .FirstOrDefaultAsync(m => m.MovieId == id);

            var rateTotal = _context.Comment.Where(x => x.MovieId == id).Sum(x => x.MovieRating);
            var rateCount = _context.Comment.Where(x => x.MovieId == id).Count();
            if (rateTotal != 0 && rateCount != 0)
            {
                ViewData["TotalRate"] = Convert.ToInt32(rateTotal * 2 / rateCount);
            }
            else
            {
                ViewData["TotalRate"] = 0;
            }

            return View(movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
