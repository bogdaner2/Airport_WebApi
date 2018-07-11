using System;
using System.Collections.Generic;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.DataAccess.Repositories;
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
            if(id > 0)
            {
                var result = repository.Tickets.Get(id);
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public bool RemoveObject(int id)
        {
            if (id > 0)
            {
                try
                {
                    repository.Tickets.Remove(id);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
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
            if (obj != null)
            {
                repository.Tickets.UpdateObject(id,obj);
                return true;
            }
            return true;
        }
    }
}
