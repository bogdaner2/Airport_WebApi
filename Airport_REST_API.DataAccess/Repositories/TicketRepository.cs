using System;
using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private DataSource db;

        public TicketRepository(DataSource context)
        {
            this.db = context;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return db.Tickets;
        }
        public Ticket Get(int id)
        {
            return db.Tickets.FirstOrDefault(item => item.Id == id);
        }
        public void Add(Ticket ticket)
        {
            
            db.Tickets.Add(ticket);
        }
        public void Remove(Ticket entity)
        {
            db.Tickets.Remove(entity);
        }
        public bool UpdateObject(int id, Ticket obj)
        {
            var flag =  db.Tickets.Count(item => item.Id == id).Equals(0);
            if (flag) return false;
            db.Tickets.Where(i => i.Id == id)
                .Select(item => {
                    item.Id = obj.Id;
                    item.Number = obj.Number;
                    item.Price = obj.Price;
                    return item; }).ToList();
            return true;
        }
    }
}
