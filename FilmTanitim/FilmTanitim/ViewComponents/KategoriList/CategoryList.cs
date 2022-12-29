using FilmTanitim.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTanitim.ViewComponents.KategoriList
{
    public class CategoryList : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public CategoryList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var category = _context.Category.ToList();
            return View(category);
        }
    }
}
