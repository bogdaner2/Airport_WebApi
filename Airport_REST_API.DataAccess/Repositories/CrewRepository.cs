using System.Collections.Generic;
using System.Linq;
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
            return db.Crews;
        }

        public Crew Get(int id)
        {
            return db.Crews.FirstOrDefault(item => item.Id == id);
        }

        public void Add(Crew entity)
        {
            db.Crews.Add(entity);
        }

        public void Remove(Crew entity)
        {
            db.Crews.Remove(entity);
        }

        public bool UpdateObject(int id, Crew obj)
        {
            var flag = db.Crews.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.Crews.Where(i => i.Id == id)
                .Select(item =>
                {
                    item.Id = obj.Id;
                    item.Pilot = obj.Pilot;
                    item.Stewardesses = obj.Stewardesses;
                    return item;
                }).ToList();
            return true;
        }
    }
}
