using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.DataAccess.Repositories;
using Airport_REST_API.Services.Interfaces;

namespace Airport_REST_API.Services.Service
{
    public class AircraftService : IService<Aircraft>
    {
        private readonly IRepository<Aircraft> aircraftRepository;
        private readonly IRepository<AircraftType> typeRepository;

        public AircraftService(IRepository<Aircraft> repository, IRepository<AircraftType> types)
        {
            aircraftRepository = repository;
            typeRepository = types;
        }

        public IEnumerable<Aircraft> GetData()
        {
            throw new System.NotImplementedException();
        }

        public Aircraft GetObject(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveObject(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool AddObject(Aircraft obj)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateObject(int id, Aircraft obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
