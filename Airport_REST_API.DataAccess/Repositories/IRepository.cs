using System.Collections.Generic;

namespace Airport_REST_API.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        T Remove(T entity);
    }
}
