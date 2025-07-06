using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entity;
using WebApplication1.ProjeContext;

namespace WebApplication1.Controllers;

public class CustomerController : Controller
{
    Context context = new Context();
    // GET
    public IActionResult Index()
    {
        var values = context.Customers.ToList();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddCustomer()
    { 
        return View();
    }
    
    [HttpPost]
    public IActionResult AddCustomer(Customer customer)
    {
        if (customer.Name.Length > 1 && customer.City.Length > 1)
        {
            context.Add(customer);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Müşteri başarıyla eklendi.";
            return RedirectToAction("Index");
        }
        else
        {
            if (customer.Name.Length <= 1)
            {
                ViewBag.NameError = "Müşteri adı en az 2 karakter olmalıdır.";
            }
            if (customer.City.Length <= 1)
            {
                ViewBag.CityError = "Şehir adı en az 2 karakter olmalıdır.";
            }
            return View(customer);
        }

    }
    
    public IActionResult DeleteCustomer(int id)
    {
        var value = context.Customers.Where(x=>x.Id == id).FirstOrDefault();
        context.Remove(value);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateCustomer(int id)
    {
        var value = context.Customers.Where(x=>x.Id == id).FirstOrDefault();
        return View(value);
    }

    [HttpPost]
    public IActionResult UpdateCustomer(Customer customer)
    {
        var value = context.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
        value.Name = customer.Name;
        value.City = customer.City;
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}