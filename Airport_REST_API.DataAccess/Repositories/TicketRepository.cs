using System.Collections.Generic;
using Airport_REST_API.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    class TicketRepository : IRepository<Ticket>
    {
        private readonly List<Ticket> collection = new List<Ticket>()
        {
            new Ticket { Id = 1, Number = " ",Price = 100},
            new Ticket { Id = 2, Number = " ",Price = 150},
            new Ticket { Id = 3, Number = " ",Price = 200},
            new Ticket { Id = 4, Number = " ",Price = 250},
            new Ticket { Id = 5, Number = " ",Price = 300},
        };
        public IEnumerable<Ticket> GetAll()
        {
            return collection;
        }

        public Ticket Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Ticket Add(Ticket entity)
        {
            throw new System.NotImplementedException();
        }

        public Ticket Update(Ticket entity)
        {
            throw new System.NotImplementedException();
        }

        public Ticket Remove(Ticket entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
