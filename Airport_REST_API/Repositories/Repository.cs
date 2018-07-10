using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.Interfaces;

namespace Airport_REST_API.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> collection;

        public IEnumerable<T> GetCollection()
        {
            return collection;
        }

        public T GetObject(int id);

        public void Update(int id)
        {

        }

        public void Create()
        {

        }

        public void Delete(int id)
        {

        }
    }
}
