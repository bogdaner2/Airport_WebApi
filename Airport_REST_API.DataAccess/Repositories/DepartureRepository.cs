using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class DepartureRepository : IRepository<Departures>
    {
        private DataSource db;

        public DepartureRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Departures> GetAll()
        {
            return db.Departureses;
        }

        public Departures Get(int id)
        {
            return db.Departureses.FirstOrDefault(item => item.Id == id);
        }

        public void Add(Departures entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Departures entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateObject(int id, Departures obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
