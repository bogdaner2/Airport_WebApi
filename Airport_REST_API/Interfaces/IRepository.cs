using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Airport_REST_API.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetCollection();
        T GetObject(int id);
        T Create();
        T Update(int id);
        T Delete(int id);
    }
}
