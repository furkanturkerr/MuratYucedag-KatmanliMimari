using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;

namespace BusinessLayer.Concrete;

public class CustomerManager:ICustomerService
{
    ICustomerDal _customerDal;
    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }
    
    public void TInsert(Customer t)
    {
        _customerDal.Insert(t);
    }

    public void TUpdate(Customer t)
    {
        _customerDal.Update(t);
    }

    public void TDelete(Customer t)
    {
        _customerDal.Delete(t);
    }

    public List<Customer> TList()
    {
        return _customerDal.GetList();
    }

    public Customer TGetById(int id)
    {
        return _customerDal.GetById(id);
    }
}