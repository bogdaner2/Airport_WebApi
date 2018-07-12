using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.Services.Interfaces
{
    public interface IAircraftTypeService : IService<AircraftType>
    {
        bool AddObject(AircraftType obj);
        bool UpdateObject(int id, AircraftType obj);
    }
}
