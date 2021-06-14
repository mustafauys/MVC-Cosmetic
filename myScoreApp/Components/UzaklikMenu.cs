using Microsoft.AspNetCore.Mvc;
using myScoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Components
{
    public class UzaklikMenu : ViewComponent
    {
        private readonly AppDbContext _context;

        public UzaklikMenu(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _context.mekanUzakliklari.OrderBy(r => r.mekanUzaklikAdi);
            return View(categories);
        }
    }
}
