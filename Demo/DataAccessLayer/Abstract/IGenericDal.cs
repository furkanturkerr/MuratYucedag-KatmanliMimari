namespace DataAccessLayer.Abstract;

public interface IGenericDal <T> where T : class
{
    void Insert(T t);
    void Update(T t);
    void Delete(T t);
    List<T> GetList();
    T GetById(int id);
}