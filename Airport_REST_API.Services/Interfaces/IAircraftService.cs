using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.Services.Interfaces
{
    public interface IAircraftService : IService<Aircraft>
    {
        bool AddObject(Aircraft obj,int typeId);
        bool UpdateObject(int id, Aircraft obj,int typeId);
    }
}
