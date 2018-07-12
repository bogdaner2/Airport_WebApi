using System.Collections.Generic;
using System.Linq;
using Airport_REST_API.DataAccess;
using Airport_REST_API.DataAccess.Models;
using Airport_REST_API.Services.Interfaces;
using Airport_REST_API.Shared.DTO;
using AutoMapper;

namespace Airport_REST_API.Services.Service
{
    public class TicketService : ITicketService
    {
        private readonly UnitOfWork db;
        private readonly IMapper _mapper;

        public TicketService(UnitOfWork uof,IMapper mapper)
        {
            db = uof;
            _mapper = mapper;
        }
        public IEnumerable<Ticket> GetData()
        {
            return db.Tickets.GetAll();
        }

        public Ticket GetObject(int id)
        {
            var result = db.Tickets.Get(id);
            return result;
        }

        public bool RemoveObject(int id)
        {
            var ticket = db.Tickets.GetAll().FirstOrDefault(item => item.Id == id);
            if (ticket != null)
            {
                db.Tickets.Remove(ticket);
                return true;
            }
            return false;
        }

        public bool AddObject(TicketDTO ticket)
        {
            if (ticket != null)
            {
                db.Tickets.Add(_mapper.Map<Ticket>(ticket));
                return true;
            }
            return false;
        }

        public bool UpdateObject(int id,TicketDTO obj)
        {
            return db.Tickets.UpdateObject(id, _mapper.Map<Ticket>(obj));
        }
    }
}
