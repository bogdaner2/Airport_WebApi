using System.Collections.Generic;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;

namespace Airport_REST_API.Services.Service
{
    public class CrewService : ICrewService
    {
        private readonly UnitOfWork db;

        public CrewService(UnitOfWork uof)
        {
            db = uof;
        }

        public IEnumerable<Crew> GetData()
        {
            return db.Crews.GetAll();
        }

        public Crew GetObject(int id)
        {
            return db.Crews.Get(id);
        }

        public bool RemoveObject(int id)
        {
             db.Crews.Remove(id);
             return true;
        }

        public bool AddObject(Crew obj, int typeId)
        {
            db.Crews.Add(obj);
            return true;
        }

        public bool UpdateObject(int id, Crew obj, int typeId)
        {
            throw new System.NotImplementedException();
        }
    }
}
