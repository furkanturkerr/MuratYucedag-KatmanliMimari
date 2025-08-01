using EntityLayer;

namespace BusinessLayer.Abstract;

public interface ICustomerService : IGenericService<Customer>
{
    List<Customer> GetCustomersListWithJob();
}