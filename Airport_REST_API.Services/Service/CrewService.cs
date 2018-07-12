using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class CrewService : ICrewService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;

        public CrewService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }

        public IEnumerable<Crew> GetData()
        {
            return db.Crews.GetAll();
        }

        public Crew GetObject(int id)
        {
            return db.Crews.Get(id);
        }

        public bool RemoveObject(int id)
        {
            var crew = db.Crews.GetAll().FirstOrDefault(item => item.Id == id);
            if (crew != null)
            {
                db.Crews.Remove(crew);
                return true;
            }
            return false;
        }

        public bool AddObject(CrewDTO obj)
        {
            
            //db.Crews.Add(obj);
            return true;
        }

        public bool UpdateObject(int id, CrewDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
