using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class DepartureRepository : IRepository<Departures>
    {
        private DataSource db;

        public DepartureRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Departures> GetAll()
        {
            return db.Departureses;
        }

        public Departures Get(int id)
        {
            return db.Departureses.FirstOrDefault(item => item.Id == id);
        }

        public void Add(Departures entity)
        {
           db.Departureses.Add(entity);
        }

        public void Remove(Departures entity)
        {
            db.Departureses.Remove(entity)
        }

        public bool UpdateObject(int id, Departures obj)
        {
            var flag = db.Departureses.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.Departureses.Where(i => i.Id == id)
                .Select(item =>
                {
                    item.Id = obj.Id;
                    item.Number = obj.Number;
                    item.Crew = obj.Crew;
                    item.DepartureTime = obj.DepartureTime;
                    item.Aircraft = obj.Aircraft;
                    return item;
                }).ToList();
            return true;
        }
    }
}
