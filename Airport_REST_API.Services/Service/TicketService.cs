using System.Collections.Generic;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;

namespace Airport_REST_API.Services.Service
{
    public class TicketService : ITicketService
    {
        private readonly UnitOfWork repository;

        public TicketService(UnitOfWork repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Ticket> GetData()
        {
            return repository.Tickets.GetAll();
        }

        public Ticket GetObject(int id)
        {
            var result = repository.Tickets.Get(id);
            return result;
        }

        public bool RemoveObject(int id)
        {
               
               repository.Tickets.Remove(id);
               return true;
        }

        public bool AddObject(Ticket ticket)
        {
            if (ticket != null)
            {
                repository.Tickets.Add(ticket);
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id,Ticket obj)
        {
            repository.Tickets.UpdateObject(id,obj);
                return true;
        }
    }
}
