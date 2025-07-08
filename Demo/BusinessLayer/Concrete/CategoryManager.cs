using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;

namespace BusinessLayer.Concrete;

public class CategoryManager:ICategoryService
{
    ICategoryDal _categoryDal;
    
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    
    public void TInsert(Category t)
    {
        _categoryDal.Insert(t);
    }

    public void TUpdate(Category t)
    {
        _categoryDal.Update(t);
    }

    public void TDelete(Category t)
    {
        _categoryDal.Delete(t);
    }

    public List<Category> TList()
    {
        return _categoryDal.GetList();
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }
}