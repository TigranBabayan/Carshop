using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarShop.Models;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationContext db;
        public AdminController(ApplicationContext context)
        {
            db = context;
        }
       [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Admin admin = await db.Admin.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (admin != null)
                {
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Admin");
                }
                ModelState.AddModelError("","Գաղնաբառը կամ Email-ը սխալ է");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Admin admin = await db.Admin.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (admin == null)
                {
                    // добавляем пользователя в бд
                    db.Admin.Add(new Admin { Email = model.Email, Password = model.Password });
                    await db.SaveChangesAsync();

                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Login", "Admin");
                }
                else
                    ModelState.AddModelError("", "Գաղնաբառը կամ Email-ը սխալ է");
            }
            return View(model);
        }
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
    }
}