using System;
using System.Collections.Generic;
using System.Linq;
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
            return db.Stewardesses;
        }

        public Stewardess Get(int id)
        {
            return db.Stewardesses.FirstOrDefault(item => item.Id == id);
        }

        public void Add(Stewardess entity)
        {
            db.Stewardesses.Add(entity);
        }

        public void Remove(Stewardess entity)
        {
            db.Stewardesses.Remove(entity);
        }

        public bool UpdateObject(int id, Stewardess obj)
        {
            var flag = db.Stewardesses.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.Stewardesses.Where(i => i.Id == id)
                .Select(item =>
                {
                    item.Id = obj.Id;
                    item.FirstName = obj.FirstName;
                    item.LastName = obj.LastName;
                    item.DateOfBirth = obj.DateOfBirth;
                    return item;
                }).ToList();
            return true;
        }
    }
}
