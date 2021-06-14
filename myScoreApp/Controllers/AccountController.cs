using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using myScoreApp.ViewModels;

namespace myScoreApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AccountController( SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
           
            _signInManager = signInManager;
            _userManager = userManager;

        }
        [HttpGet]
        public IActionResult Login()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login obj)
        {
            if (ModelState.IsValid)
            {
                // Girilen kullanıcı adına sahip kullanıcı varse "user" değişkenine atanır
                var user = await _userManager.FindByNameAsync(obj.username);

                
                if (user != null)
                {
                    
                    var result = await _signInManager.PasswordSignInAsync(user, obj.password, false, false);

                    // Giriş başarılıysa Anasayfaya yönlendirme yapılır.
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                // Kullanıcı yoksa hata döner.
                
                ModelState.AddModelError("", "Kullanıcı adı veya Parola hatalı.");
                return View(obj);
            }
            return View(obj);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Login obj)
        {
            if (ModelState.IsValid)
            {
                
                var user = new IdentityUser()
                { UserName = obj.username };
                
                var result = await _userManager.CreateAsync(user, obj.password);

                var isEmailAlreadyExists = _userManager.FindByNameAsync(obj.username);
                
                if (result.Succeeded)
                {
                    var result2 = await _signInManager.PasswordSignInAsync(user, obj.password, false, false);

                    
                    if (result2.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                if (isEmailAlreadyExists != null)
                {
                    ModelState.AddModelError("", "Kullanıcı adı zaten var");
                }


                return View(obj);
            }
            return View(obj);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
