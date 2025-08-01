using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
{
    public List<Customer> GetCustomerListWithJob()
    {
        using (var c = new Context())
        {
            return c.Customers.Include(x => x.Job).ToList();
        }
    }
}