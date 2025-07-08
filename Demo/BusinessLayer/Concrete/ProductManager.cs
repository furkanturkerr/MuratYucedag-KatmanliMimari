using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;

namespace BusinessLayer.Concrete;

public class ProductManager : IProductService
{
    IProductDal _productDal;
    
    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    
    public void TInsert(Product t)
    {
        _productDal.Insert(t);
    }

    public void TUpdate(Product t)
    {
        _productDal.Update(t);
    }

    public void TDelete(Product t)
    {
        _productDal.Delete(t);
    }

    public List<Product> TList()
    {
        return _productDal.GetList();
    }

    public Product TGetById(int id)
    {
        return _productDal.GetById(id);
    }
}