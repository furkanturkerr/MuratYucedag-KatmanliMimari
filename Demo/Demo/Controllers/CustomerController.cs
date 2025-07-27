using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.Controllers;

public class CustomerController : Controller
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    JobManager jobManager = new JobManager(new EfJobDal());
    // GET
    public IActionResult Index()
    {
        var values = customerManager.GetCustomersListWithJob();
        return View(values);
    }
    
    [HttpGet]
    public IActionResult AddCustomer()
    {
        List<SelectListItem> values = (from x in jobManager.TList()
            select new SelectListItem
            {
                Text = x.Name,
                Value = x.JobId.ToString()
            }).ToList();
        ViewBag.v = values;
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
        List<SelectListItem> values = (from x in jobManager.TList()
            select new SelectListItem
            {
                Text = x.Name,
                Value = x.JobId.ToString()
            }).ToList();
        ViewBag.v = values;
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