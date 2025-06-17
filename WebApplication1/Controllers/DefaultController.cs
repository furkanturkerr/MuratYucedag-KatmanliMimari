using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class DefaultController : Controller
{
    void Mesajlar()
    {
        ViewBag.Mesaj = "Merhaba";
    }
    public IActionResult Index()
    {
        Mesajlar();
        return View();
    }

    public IActionResult Urunler()
    {
        return View();
    }
}