using System.Collections.Generic;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Remove(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
