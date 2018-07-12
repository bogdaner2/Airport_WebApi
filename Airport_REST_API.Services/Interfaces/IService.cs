using System.Collections.Generic;

namespace Airport_REST_API.Services.Interfaces { 
    public interface IService<T>
    {
        IEnumerable<T> GetData();
        T GetObject(int id);
        bool RemoveObject(int id);
        bool AddObject(T obj);
        bool UpdateObject(int id, T obj);
    }
}
