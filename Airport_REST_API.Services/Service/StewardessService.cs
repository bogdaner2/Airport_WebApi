using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class StewardessService : IStewardessService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;

        public StewardessService(UnitOfWork uof, IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }

        public IEnumerable<Stewardess> GetData()
        {
            return db.Stewardess.GetAll();
        }

        public Stewardess GetObject(int id)
        {
            return db.Stewardess.Get(id);
        }

        public bool RemoveObject(int id)
        {
            var stewardess = db.Stewardess.GetAll().FirstOrDefault(item => item.Id == id);
            if (stewardess != null)
            {
                db.Stewardess.Remove(stewardess);
                return true;
            }
            return false;
        }

        public bool AddObject(StewardessDTO obj)
        {
            if (obj != null)
            {
                db.Stewardess.Add(_mapper.Map<Stewardess>(obj));
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id, StewardessDTO obj)
        {
            return db.Stewardess.UpdateObject(id, _mapper.Map<Stewardess>(obj));
        }
    }
}
