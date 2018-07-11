using System;
using System.Collections.Generic;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.DataAccess.Repositories;
using Airport_REST_API.Services.Interfaces;

namespace Airport_REST_API.Services.Service
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> repository;

        public TicketService(IRepository<Ticket> repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Ticket> GetData()
        {
            return repository.GetAll();
        }

        public Ticket GetObject(int id)
        {
            if(id > 0)
            {
                var result = repository.Get(id);
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
                    repository.Remove(id);
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
                repository.Add(ticket);
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id,Ticket obj)
        {
            if (obj != null)
            {
                repository.UpdateObject(id,obj);
                return true;
            }
            return true;
        }
    }
}
