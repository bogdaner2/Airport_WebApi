﻿using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class AircraftRepository : IRepository<Aircraft>
    {
        public IEnumerable<Aircraft> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Aircraft Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Aircraft entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateObject(int id, Aircraft obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
