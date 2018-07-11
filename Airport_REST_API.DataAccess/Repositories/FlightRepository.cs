using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    class FlightRepository : IRepository<Flight>
    {
        private DataSource db;

        public FlightRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Flight> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Flight Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Flight entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateObject(int id, Flight obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
