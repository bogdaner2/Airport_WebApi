using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class AircraftTypeRepository : IRepository<AircraftType>
    {
        private DataSource db;

        public AircraftTypeRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<AircraftType> GetAll()
        {
            return db.AircraftTypes;
        }

        public AircraftType Get(int id)
        {
            return db.AircraftTypes.FirstOrDefault(i => i.Id == id);
        }

        public void Add(AircraftType entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(AircraftType entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateObject(int id, AircraftType obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
