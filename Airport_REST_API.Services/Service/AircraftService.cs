using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class AircraftService : IAircraftService
    {
        private readonly UnitOfWork db;
        private IMapper _mapper;

        public AircraftService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }

        public IEnumerable<Aircraft> GetData()
        {
            return db.Aircrafts.GetAll();
        }

        public Aircraft GetObject(int id)
        {
            return db.Aircrafts.Get(id);
        }

        public bool RemoveObject(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool AddObject(AircraftDTO obj)
        {
            var type = db.Types.GetAll().FirstOrDefault(t => t.Id == obj.TypeId);
            var aircraft = _mapper.Map<Aircraft>(obj);
            aircraft.Type = type;
            db.Aircrafts.Add(aircraft);
            return true;
        }

        public bool UpdateObject(int id, AircraftDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
