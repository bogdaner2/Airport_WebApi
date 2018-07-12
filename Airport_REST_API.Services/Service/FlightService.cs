using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class FlightService : IFlightService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;
        public FlightService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
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
            var flight = db.Flights.GetAll().FirstOrDefault(a => a.Id == id);
            if (flight == null) { return false; }
            db.Flights.Remove(flight);
            return true;
        }

        public bool AddObject(FlightDTO obj)
        {
            var tickets = db.Tickets.GetAll().Where(i => obj.TicketsId.Contains(i.Id) == true).ToList();
            if (tickets.Count == 0 || obj == null ) { return false; }
            var flight = _mapper.Map<Flight>(obj);
            flight.Ticket = tickets;
            db.Flights.Add(flight);
            return true;
        }

        public bool UpdateObject(int id, FlightDTO obj)
        {
            var tickets = db.Tickets.GetAll().Where(i => obj.TicketsId.Contains(i.Id) == true).ToList();
            if (tickets.Count == 0 || obj == null) { return false; }
            var flight = _mapper.Map<Flight>(obj);
            flight.Ticket = tickets;
            return db.Flights.UpdateObject(id, flight);
        }
    }
}
