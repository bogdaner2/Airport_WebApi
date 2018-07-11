using System;
using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly List<Ticket> collection = new List<Ticket>
        {
            new Ticket {Id = 1, DepartureId = 1, Number = "fdg ", Price = 100},
            new Ticket {Id = 2, DepartureId = 1, Number = "fdg ", Price = 150},
            new Ticket {Id = 3, DepartureId = 2, Number = "dfg ", Price = 200},
            new Ticket {Id = 4, DepartureId = 2, Number = "fdg ", Price = 250},
            new Ticket {Id = 5, DepartureId = 2, Number = "fdg", Price = 300},
        };
        public IEnumerable<Ticket> GetAll()
        {
            return collection;
        }
        public Ticket Get(int id)
        {
            return collection.FirstOrDefault(item => item.Id == id);
        }
        public void Add(Ticket ticket)
        {
            collection.Add(ticket);
        }
        public void Remove(int id)
        {
            var item = collection.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                collection.Remove(item);
            }
            else
            {
                throw new Exception();
            }
        }
        public void UpdateObject(int id, Ticket obj)
        {
            collection.Where(i => i.Id == id)
                .Select(item => {
                    item.Id = obj.Id;
                    item.DepartureId = obj.DepartureId;
                    item.Price = obj.Price;
                    item.Number = obj.Number;
                    return item; }).ToList();
        }
    }
}
