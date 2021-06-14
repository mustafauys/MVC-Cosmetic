using Microsoft.AspNetCore.Mvc;
using myScoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Components
{
    public class KategoriMenu : ViewComponent
    {
        private readonly AppDbContext _context;

        public KategoriMenu(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _context.kategoriler.OrderBy(r => r.kategoriAdi);
            return View(categories);
        }

    }
}
