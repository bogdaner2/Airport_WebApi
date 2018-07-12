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

        public void Remove(Flight entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateObject(int id, Flight obj)
        {
            db.Flights.Where(i => i.Id == id)
                .Select(item => {
                    item.Id = obj.Id;
                    item.ArrivelTime = obj.ArrivelTime;
                    item.DepartureTime = obj.DepartureTime;
                    item.Number = obj.Number;
                    item.PointOfDeparture = obj.PointOfDeparture;
                    item.Destination = obj.Destination;
                    item.Ticket = obj.Ticket;
                    return item;
                }).ToList();
            return true;
        }
    }
}
