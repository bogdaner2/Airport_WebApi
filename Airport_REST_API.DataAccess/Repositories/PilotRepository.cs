using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class PilotRepository : IRepository<Pilot>
    {
        private DataSource db;

        public PilotRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Pilot> GetAll()
        {
            return db.Pilots;
        }

        public Pilot Get(int id)
        {
            return db.Pilots.FirstOrDefault(item => item.Id == id);
        }

        public void Add(Pilot entity)
        {
            db.Pilots.Add(entity);
        }

        public void Remove(Pilot entity)
        {
            db.Pilots.Remove(entity);
        }

        public bool UpdateObject(int id, Pilot obj)
        {
            var flag = db.Pilots.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.Pilots.Where(i => i.Id == id)
                .Select(item =>
                {
                    item.Id = obj.Id;
                    item.FirstName = obj.FirstName;
                    item.LastName = obj.LastName;
                    item.DateOfBirth = obj.DateOfBirth;
                    item.Experierence = obj.Experierence;
                    return item;
                }).ToList();
            return true;
        }
    }
}
