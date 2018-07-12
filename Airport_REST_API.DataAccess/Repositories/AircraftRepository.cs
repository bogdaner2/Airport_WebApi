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
            //db.Aircrafts.Where(i => i.Id == id)
            //    .Select(item =>
            //    {
            //        item.Id = obj.Id;
            //        item.DepartureId = obj.DepartureId;
            //        item.Price = obj.Price;
            //        item.Number = obj.Number;
            //        return item;
            //    }).ToList();
            return true;
        }
    }
}
