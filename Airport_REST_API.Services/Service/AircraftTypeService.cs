using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;

namespace Airport_REST_API.Services.Service
{
    public class AircraftTypeService : IAircraftTypeService
    {
        private readonly UnitOfWork db;

        public AircraftTypeService(UnitOfWork uof)
        {
            db = uof;
        }
        public IEnumerable<AircraftType> GetData()
        {
            return db.Types.GetAll();
        }

        public AircraftType GetObject(int id)
        {
            return db.Types.GetAll().FirstOrDefault(item => item.Id == id);
        }

        public bool RemoveObject(int id)
        {
           db.Types.Remove(id);
           return true;
        }

        public bool AddObject(AircraftType obj)
        {
            if (obj != null)
            {
                db.Types.Add(obj);
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id, AircraftType obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
