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
        public void Remove(int id)
        {
            var item = db.Tickets.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                db.Tickets.Remove(item);
            }
            else
            {
                throw new Exception();
            }
        }
        public void UpdateObject(int id, Ticket obj)
        {
            db.Tickets.Where(i => i.Id == id)
                .Select(item => {
                    item.Id = obj.Id;
                    item.DepartureId = obj.DepartureId;
                    item.Price = obj.Price;
                    item.Number = obj.Number;
                    return item; }).ToList();
        }
    }
}
