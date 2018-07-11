using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    class PilotRepository : IRepository<Pilot>
    {
        private DataSource db;

        public PilotRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Pilot> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Pilot Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Pilot entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateObject(int id, Pilot obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
