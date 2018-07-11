using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    class DepartureRepository : IRepository<Departures>
    {
        private DataSource db;

        public DepartureRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Departures> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Departures Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Departures entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateObject(int id, Departures obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
