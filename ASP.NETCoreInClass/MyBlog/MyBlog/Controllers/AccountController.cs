using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.ViewModel;


namespace MyBlog.Controllers
{
    public class AccountController : Controller
        {
            private readonly UserManager<AppUser> userManager;
            private readonly SignInManager<AppUser> signInManager;
            protected readonly IHostingEnvironment webHostEnvironment;
        public AccountController(UserManager<AppUser> userManager,
                SignInManager<AppUser> signInManager, IHostingEnvironment hostEnvironment)
            {
                this.userManager = userManager;
                this.signInManager = signInManager;
                webHostEnvironment = hostEnvironment;
        }

            [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
            {
                if (ModelState.IsValid)
                {
                string uniqueFileName = UploadedFile(model);
                var user = new AppUser {
                        UserName = model.Email,
                        Email = model.Email,
                        City = model.City,
                        Street = model.Street,
                        Position = model.Position,
                        ImageName = uniqueFileName
                };

                
       
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        //return RedirectToAction("Blog", "Post");
                    return RedirectToRoute("default", new { controller = "Blog", action = "Index" });
                }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View(model);
            }

        private string UploadedFile(RegisterViewModel model)
        {
            string uniqueFileName = null;

            if (model.ImageName != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageName.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageName.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [HttpPost]
            public async Task<IActionResult> Logout()
            {
                await signInManager.SignOutAsync();
                //return RedirectToAction("Blog", "Index");
            return RedirectToRoute("default", new { controller = "Blog", action = "Index" });
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Blog");
                        //return RedirectToRoute("default", new { controller = "Blog", action = "Index" });
                    }

                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}