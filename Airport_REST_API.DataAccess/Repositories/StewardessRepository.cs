using System;
using System.Collections.Generic;
using System.Text;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class StewardessRepository : IRepository<Stewardess>
    {
        private DataSource db;
        public StewardessRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Stewardess> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stewardess Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Stewardess entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateObject(int id, Stewardess obj)
        {
            throw new NotImplementedException();
        }
    }
}
