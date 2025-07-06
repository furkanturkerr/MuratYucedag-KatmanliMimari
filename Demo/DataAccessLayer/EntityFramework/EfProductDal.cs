using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer;

namespace DataAccessLayer.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    
}