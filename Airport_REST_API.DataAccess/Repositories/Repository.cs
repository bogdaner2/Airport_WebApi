using System.Collections.Generic;
using Airport_REST_API.DataAccess.Repositories;

namespace Airport_REST_API.Repositories
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
