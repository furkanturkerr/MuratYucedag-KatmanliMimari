using Demo.Models;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;
[AllowAnonymous]

public class LoginController : Controller
{
    private readonly SignInManager<AppUser> _signInManager;

    public LoginController(SignInManager<AppUser> signInManager)
    {
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task <IActionResult> Index(UserLoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var resault = await _signInManager.PasswordSignInAsync(model.Usernme,model.Password, false, false  );
            if (resault.Succeeded)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ModelState.AddModelError("", "Hatalı Kullanıcı adı veya şifre");
            }
        }
        return View();
    }
}