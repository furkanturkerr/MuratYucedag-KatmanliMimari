using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;

namespace BusinessLayer.Concrete;

public class JobManager : IGenericService<Job>
{
    IJobDal _jobDal;

    public JobManager(IJobDal jobDal)
    {
        _jobDal = jobDal;
    }
    
    public void TInsert(Job t)
    {
        _jobDal.Insert(t);
    }

    public void TUpdate(Job t)
    {
        _jobDal.Update(t);
    }

    public void TDelete(Job t)
    {
        _jobDal.Delete(t);
    }

    public List<Job> TList()
    {
        return _jobDal.GetList();
    }

    public Job TGetById(int id)
    {
        return _jobDal.GetById(id);
    }
}