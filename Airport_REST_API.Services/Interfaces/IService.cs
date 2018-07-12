using System.Collections.Generic;

namespace Airport_REST_API.Services.Interfaces { 
    public interface IService<T,T_DTO>
    {
        IEnumerable<T> GetData();
        T GetObject(int id);
        bool RemoveObject(int id);
        bool AddObject(T_DTO obj);
        bool UpdateObject(int id, T_DTO obj);
    }
}
