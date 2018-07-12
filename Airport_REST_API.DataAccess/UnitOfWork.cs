using System;
using System.Collections.Generic;
using System.Text;
using Airport_REST_API.DataAccess.Repositories;

namespace Airport_REST_API.DataAccess
{
    public class UnitOfWork
    {
        private DataSource db = new DataSource();
        private TicketRepository _ticketRepository;
        private AircraftRepository _aircraftRepository;
        private AircraftTypeRepository _typeRepository;
        private CrewRepository _crewRepository;

        public UnitOfWork(AircraftRepository aircraftRepository,
            TicketRepository ticketRepository,
            AircraftTypeRepository typeRepository,
            CrewRepository crewRepository)
        {
            _aircraftRepository = aircraftRepository;
            _ticketRepository = ticketRepository;
            _typeRepository = typeRepository;
            _crewRepository = crewRepository;
        }

        public TicketRepository Tickets
        {
            get
            {
                if (_ticketRepository == null)
                    _ticketRepository = new TicketRepository(db);
                return _ticketRepository;
            }
        }
        public AircraftRepository Aircrafts
        {
            get
            {
                if (_aircraftRepository == null)
                    _aircraftRepository = new AircraftRepository(db);
                return _aircraftRepository;
            }
        }
        public AircraftTypeRepository Types
        {
            get
            {
                if (_typeRepository == null)
                    _typeRepository = new AircraftTypeRepository(db);
                return _typeRepository;
            }
        }
        public CrewRepository Crews
        {
            get
            {
                if (_crewRepository == null)
                    _crewRepository = new CrewRepository(db);
                return _crewRepository;
            }
        }
    }

}
