using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myScoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Components
{
    public class Benzer : ViewComponent
    {
        private readonly AppDbContext _context;

        public Benzer(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var mekanlar = _context.urunler.Include(c => c.user).ToList<Mekan>();
            return View(mekanlar.OrderBy(a => Guid.NewGuid()));
        }

    }
}
