using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class AircraftTypeService : IAircraftTypeService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;

        public AircraftTypeService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }
        public IEnumerable<AircraftTypeDTO> GetData()
        {
            return _mapper.Map<List<AircraftTypeDTO>>(db.Types.GetAll());
        }

        public AircraftTypeDTO GetObject(int id)
        {
            return _mapper.Map<AircraftTypeDTO>(db.Types.Get(id));
        }

        public bool RemoveObject(int id)
        {
            var type = db.Types.GetAll().FirstOrDefault(item => item.Id == id);
            if (type != null)
            {
                db.Types.Remove(type);
                return true;
            }
            return false;
        }

        public bool AddObject(AircraftTypeDTO obj)
        {
            if (obj != null)
            {
                db.Types.Add(_mapper.Map<AircraftType>(obj));
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id, AircraftTypeDTO obj)
        {
            return db.Types.UpdateObject(id, _mapper.Map<AircraftType>(obj));
        }
    }
}
