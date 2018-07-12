using System;
using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class AircraftRepository : IRepository<Aircraft>
    {
        private DataSource db;

        public AircraftRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<Aircraft> GetAll()
        {
            return db.Aircrafts;
        }

        public Aircraft Get(int id)
        {
            return db.Aircrafts.FirstOrDefault(item => item.Id == id);
        }

        public void Add(Aircraft entity)
        {
            db.Aircrafts.Add(entity);
        }

        public void Remove(Aircraft entity)
        {
            db.Aircrafts.Remove(entity);
        }

        public bool UpdateObject(int id, Aircraft obj)
        {
            var flag = db.Aircrafts.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.Aircrafts.Where(i => i.Id == id)
                .Select(item =>
                {
                    item.Id = obj.Id;
                    item.Type= obj.Type;
                    item.Lifetime = obj.Lifetime;
                    item.Name= obj.Name;
                    item.ReleseDate = obj.ReleseDate;
                    return item;
                }).ToList();
            return true;
        }
    }
}
