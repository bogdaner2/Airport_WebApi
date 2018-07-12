using System;
using System.Collections.Generic;
using System.Text;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class CrewRepository : IRepository<Crew>
    {
        private DataSource db;

        public CrewRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Crew> GetAll()
        {
            throw new NotImplementedException();
        }

        public Crew Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Crew entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateObject(int id, Crew obj)
        {
            throw new NotImplementedException();
        }
    }
}
