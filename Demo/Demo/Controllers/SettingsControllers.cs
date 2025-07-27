using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;

public class SettingsControllers : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}