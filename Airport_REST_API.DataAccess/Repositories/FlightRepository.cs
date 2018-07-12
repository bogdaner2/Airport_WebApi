using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class FlightRepository : IRepository<Flight>
    {
        private DataSource db;

        public FlightRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Flight> GetAll()
        {
            return db.Flights;
        }

        public Flight Get(int id)
        {
            return db.Flights.FirstOrDefault(item => item.Id == id);
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
