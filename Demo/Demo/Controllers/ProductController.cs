using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;

public class ProductController : Controller
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    
    public IActionResult Index()
    {
        var values = productManager.TList();
        return View(values);
    }
}