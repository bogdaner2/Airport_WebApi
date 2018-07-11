using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.DataAccess.Repositories;
using Airport_REST_API.Services.Interfaces;

namespace Airport_REST_API.Services.Service
{
    public class AircraftService : IAircraftService
    {
        private readonly UnitOfWork db;

        public AircraftService(UnitOfWork uof)
        {
            db = uof;
        }

        public IEnumerable<Aircraft> GetData()
        {
            return db.Aircrafts.GetAll();
        }

        public Aircraft GetObject(int id)
        {
            return db.Aircrafts.Get(id);
        }

        public bool RemoveObject(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool AddObject(Aircraft obj, int typeId)
        {
            var type = db.Types.GetAll().FirstOrDefault(t => t.Id == typeId);
            obj.Type = type;
            db.Aircrafts.Add(obj);
            return true;
        }

        public bool UpdateObject(int id, Aircraft obj, int typeId)
        {
            throw new System.NotImplementedException();
        }
    }
}
