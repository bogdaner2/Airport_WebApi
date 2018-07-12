using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class DepartureService : IDepartureService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;

        public DepartureService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }

        public IEnumerable<Departures> GetData()
        {
            return db.Departures.GetAll();
        }

        public Departures GetObject(int id)
        {
            return db.Departures.Get(id);
        }

        public bool RemoveObject(int id)
        {
            var departure = db.Departures.GetAll().FirstOrDefault(a => a.Id == id);
            if (departure == null) { return false; }
            db.Departures.Remove(departure);
            return true;
        }

        public bool AddObject(DeparturesDTO obj)
        {
            var crew = db.Crews.GetAll().FirstOrDefault(t => t.Id == obj.CrewId);
            var aircraft = db.Aircrafts.GetAll().FirstOrDefault(t => t.Id == obj.AircraftId);
            if (crew == null || obj == null || aircraft == null) { return false; }
            var departure = _mapper.Map<Departures>(obj);
            departure.Aircraft = aircraft;
            departure.Crew = crew;
            db.Departures.Add(departure);
            return true;
        }

        public bool UpdateObject(int id, DeparturesDTO obj)
        {
            var crew = db.Crews.GetAll().FirstOrDefault(t => t.Id == obj.CrewId);
            var aircraft = db.Aircrafts.GetAll().FirstOrDefault(t => t.Id == obj.AircraftId);
            if (crew == null || obj == null || aircraft == null) { return false; }
            var departure = _mapper.Map<Departures>(obj);
            departure.Aircraft = aircraft;
            departure.Crew = crew;
            return db.Departures.UpdateObject(id, departure);
        }
    }
}
