using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class PilotService : IPilotService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;

        public PilotService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }

        public IEnumerable<PilotDTO> GetData()
        {
            return _mapper.Map<List<PilotDTO>>(db.Pilots.GetAll());
        }

        public PilotDTO GetObject(int id)
        {
            return _mapper.Map<PilotDTO>(db.Pilots.Get(id));
        }

        public bool RemoveObject(int id)
        {
            var pilot = db.Pilots.GetAll().FirstOrDefault(item => item.Id == id);
            if (pilot != null)
            {
                db.Pilots.Remove(pilot);
                return true;
            }
            return false;
        }

        public bool AddObject(PilotDTO obj)
        {
            if (obj != null)
            {
                db.Pilots.Add(_mapper.Map<Pilot>(obj));
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id, PilotDTO obj)
        {
            return db.Pilots.UpdateObject(id, _mapper.Map<Pilot>(obj));
        }
    }
}
