using System.Collections.Generic;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;

namespace Airport_REST_API.Services.Service
{
    public class FlightService : IFlightService
    {
        private UnitOfWork db;

        public FlightService(UnitOfWork uof)
        {
            db = uof;
        }
        public IEnumerable<Flight> GetData()
        {
            return db.Flights.GetAll();
        }

        public Flight GetObject(int id)
        {
            return db.Flights.Get(id);
        }

        public bool RemoveObject(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool AddObject(FlightDTO obj)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateObject(int id, FlightDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
