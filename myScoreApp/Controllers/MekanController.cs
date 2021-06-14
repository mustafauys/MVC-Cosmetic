using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using myScoreApp.Models;
using myScoreApp.Models.Comments;
using myScoreApp.ViewModels;

namespace myScoreApp.Controllers
{
    public class MekanController : Controller
    {
        private readonly IDepo _depo;
        private readonly AppDbContext _appDbContext;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHostingEnvironment _appEnvironment;
       
        public MekanController(IDepo depo, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager, AppDbContext appDbContext, IHostingEnvironment appEnvironment)
        {
            _appDbContext = appDbContext;
            _depo = depo;
            _signInManager = signInManager;
            _userManager = userManager;
            _appEnvironment = appEnvironment;
        }

        [Authorize]
        public IActionResult MekanEkle()
        {
            GetViewBagData();
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> MekanEkle(Mekan mekan)
        {
            // ModelState nesnesini temizler
            ModelState.Clear();
            // Formdaki eksik kullanıcı adını tamamlar.
            mekan.user = await _userManager.GetUserAsync(HttpContext.User);
            // Formu tekrar doğruluyor.
            TryValidateModel(mekan);
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;
                        
                        var uploads = Path.Combine(_appEnvironment.WebRootPath, "img\\mekan");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                mekan.mekanResim = fileName;
                            }

                        }
                    }
                }

                _depo.MekanEkle(mekan);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        public async Task<IActionResult> MekanSil(int id)
        {
            // Giriş yapan kullanıcıyı alır.
            var user = await _userManager.GetUserAsync(HttpContext.User);
            try
            {                
                if (_depo.MekanGetir(id).user == user)
                    _depo.MekanSil(id);
                else
                    return NotFound("404 Sayfa Bulunamadı");
            }
            catch (Exception )
            {
                return NotFound("404 Sayfa Bulunamadı");
            }
            return RedirectToAction("BenimMekanlar", "Mekan");
        }
        public void GetViewBagData()
        {
            ViewBag.CatName = new SelectList(_appDbContext.kategoriler, "kategoriAdi", "kategoriAdi");
            ViewBag.Uzaklik = new SelectList(_appDbContext.mekanUzakliklari, "mekanUzaklikAdi", "mekanUzaklikAdi");
        }
        [Authorize]
        public async Task<IActionResult> MekanGuncelle(int id)
        {
            GetViewBagData();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var mekan = _depo.MekanGetir(id);
            if (mekan == null) return NotFound("404 Sayfa Bulunamadı");
            if (mekan.user != user) return NotFound("404 Sayfa Bulunamadı");
            return View(mekan);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> MekanGuncelle(int id, Mekan mekan)
        {
            ModelState.Clear();
            mekan.user = await _userManager.GetUserAsync(HttpContext.User);
            TryValidateModel(mekan);
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;                    
                        var uploads = Path.Combine(_appEnvironment.WebRootPath, "img\\mekan");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                mekan.mekanResim = fileName;
                            }

                        }
                    }
                }
                _depo.MekanGuncelle(id, mekan);
                return RedirectToAction("BenimMekanlar", "Mekan");
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        public async Task<IActionResult> BenimMekanlar()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View(_depo.BenimMekanlar(user));
        }
        [HttpPost]
        public async Task<IActionResult> Comment(YorumViewModel vm)
        {

            var temp = vm.UserName;
            if (!ModelState.IsValid)
            {


                return RedirectToAction("mekan", temp, new { id = vm.mekanId });
            }
            var mekan = _depo.MekanGetir(vm.mekanId);
          
            if (vm.MainCommentId == 0)
            {
                mekan.MainComments = mekan.MainComments ?? new List<MainComment>();
                mekan.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now,
                    UserName = _userManager.GetUserName(User),
                });
                _depo.YorumEkle(mekan);
            }
            else
            {
                var comment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now,
                    UserName = _userManager.GetUserName(User),
                };
                _depo.AltYorumEkle(comment);
            }
            await _depo.SaveChangesAsync();
            return RedirectToAction("mekan", temp, new { id = vm.mekanId });


        }
        [HttpGet]
        public IActionResult Kategori(string id)
        {
           
            return View(_depo.TumMekanlar().Where(x=> x.CatName== id));
        }
        [HttpGet]
        public  IActionResult MekanUzaklik(string id)
        {

            return View(_depo.TumMekanlar().Where(x => x.Fiyat == id));
        }
    }
}
