using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class AircraftTypeRepository : IRepository<AircraftType>
    {
        private DataSource db;

        public AircraftTypeRepository(DataSource context)
        {
            db = context;
        }
        public IEnumerable<AircraftType> GetAll()
        {
            return db.AircraftTypes;
        }

        public AircraftType Get(int id)
        {
            return db.AircraftTypes.FirstOrDefault(i => i.Id == id);
        }

        public void Add(AircraftType entity)
        {
           db.AircraftTypes.Add(entity);
        }

        public void Remove(AircraftType entity)
        {
            db.AircraftTypes.Remove(entity);
        }

        public bool UpdateObject(int id, AircraftType obj)
        {
            var flag = db.AircraftTypes.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.AircraftTypes.Where(i => i.Id == id)
                .Select(item =>
                {
                    item.Id = obj.Id;
                    item.CarryingCapacity = obj.CarryingCapacity;
                    item.CountOfSeats = obj.CountOfSeats;
                    item.Model = obj.Model;
                    return item;
                }).ToList();
            return true;
        }
    }
}
