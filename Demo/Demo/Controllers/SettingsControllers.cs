using Demo.Models;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;

public class SettingsControllers : Controller
{
    private readonly UserManager<AppUser> _userManager;
    
    public SettingsControllers(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    
    [HttpGet]
    public async Task <IActionResult> Index()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.Email = values.Email;
        return View(userEditViewModel);
    }
    
    [HttpPost]
    public async Task <IActionResult> Index(UserEditViewModel userEditViewModel)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        user.Name = userEditViewModel.Name;
        user.Surname = userEditViewModel.SurName;
        user.Email = userEditViewModel.Email;
        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
        await _userManager.UpdateAsync(user);
        return RedirectToAction("Index", "Product"); 
    }
}