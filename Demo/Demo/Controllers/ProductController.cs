using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}