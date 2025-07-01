using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entity;
using WebApplication1.ProjeContext;

namespace WebApplication1.Controllers;

public class ProductController : Controller
{
    Context context = new Context();
    // GET
    public IActionResult Index()
    {
        var values = context.Products.ToList();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddProduct()
    { 
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        context.Add(product);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult DeleteProduct(int id)
    {
        var value = context.Products.Where(x=>x.Id == id).FirstOrDefault();
        context.Remove(value);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    //Get işlemi ile ürünu bulduk
    [HttpGet]
    public IActionResult UpdateProduct(int id)
    {
        var value = context.Products.Where(x=>x.Id == id).FirstOrDefault();
        return View(value);
    }

    //Post işlemi ile butona bastıktan sonra ürünü güncelledik
    [HttpPost]
    public IActionResult UpdateProduct(Product product)
    {
        var value = product;
        value.Name=product.Name;
        value.Price=product.Price;
        value.Stock=product.Stock;
        context.Update(value);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}