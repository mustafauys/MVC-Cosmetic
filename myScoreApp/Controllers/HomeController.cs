using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using myScoreApp.Models;

namespace myScoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepo depo;
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private static string username2;
        private static int mekanid;
        public HomeController(IDepo _depo, UserManager<IdentityUser> userManager, AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            depo = _depo;
            _userManager = userManager;
        }
        public void GetViewBagData()
        {
            ViewBag.CatName = new SelectList(_appDbContext.kategoriler, "kategoriAdi", "kategoriAdi");
            ViewBag.Uzaklik = new SelectList(_appDbContext.mekanUzakliklari, "mekanUzaklikAdi", "mekanUzaklikAdi");
        }
        public IActionResult Index()
        {
            GetViewBagData();
            return View(depo.TumMekanlar());
        }
        [Route("{username}")]
        public async Task<IActionResult> MekanDetay(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null) return NotFound("404 Sayfa Bulunamadı");
            var temp = depo.BenimMekanlar(user);
            return View("Index", temp);
        }
        [Route("{username}/mekan/{id?}")]
        public IActionResult MekanDetay(string username, int id)
        {
            ViewBag.MekanCat = depo.MekanGetir(id).CatName;
            ViewBag.MekanID = depo.MekanGetir(id).mekanId;
            mekanid = id;
            username2 = username;
            return View(depo.MekanGetir(id));

        }
        [Authorize]
        public async Task<IActionResult> YorumSil(int id)
        {
            // Giriş yapan kullanıcı alınır.
            var user = await _userManager.GetUserAsync(HttpContext.User);
            try
            {
                // ilgili post giriş yapan kullanıcıya mı ait?
                if (depo.YorumGetir(id).UserName == user.UserName)
                    depo.YorumSil(id);
                else
                    return NotFound("404 Sayfa Bulunamadı");
            }
            catch (Exception)
            {
                return NotFound("404 Sayfa Bulunamadı");
            }
            return RedirectToAction("mekan",username2, new { id = mekanid });
        }  
        [Authorize]
        public async Task<IActionResult> AltYorumSil(int id)
        {
            // Giriş yapan kullanıcı alınır.
            var user = await _userManager.GetUserAsync(HttpContext.User);
            try
            {
                
                if (depo.AltYorumGetir(id).UserName == user.UserName)
                    depo.AltYorumSil(id);
                else
                    return NotFound("404 Sayfa Bulunamadı");
            }
            catch (Exception)
            {
                return NotFound("404 Sayfa Bulunamadı");
            }
            return RedirectToAction("mekan", username2, new { id = mekanid });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
