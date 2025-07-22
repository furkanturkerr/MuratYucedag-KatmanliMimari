using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;

public class CustomerController : Controller
{
    private CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    // GET
    public IActionResult Index()
    {
        var values = customerManager.TList();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddCustomer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddCustomer(Customer p)
    {
        customerManager.TInsert(p);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteCustomer(int id)
    {
        var value = customerManager.TGetById(id);
        customerManager.TDelete(value);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateCustomer(int id)
    {
        var value = customerManager.TGetById(id);
        return View(value);
    }
    
    [HttpPost]
    public IActionResult UpdateCustomer(Customer p)
    {
        customerManager.TUpdate(p);
        return RedirectToAction("Index");
    }
}