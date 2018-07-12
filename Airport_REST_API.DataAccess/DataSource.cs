using System;
using System.Collections.Generic;
using System.Text;
using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.DataAccess
{
    public class DataSource
    {
        public List<Aircraft> Aircrafts = new List<Aircraft>
        {
            new Aircraft {Id = 1,
                ReleseDate = new DateTime(2008,6,15),
                Name = "Lastochka" ,
                Lifetime = DateTime.Parse("2024/6/26").Date - DateTime.Now,
                Type =  new AircraftType { Id = 3,CarryingCapacity = 107900,CountOfSeats = 214, Model = "Туполев Ту-204"}}
        };
        public List<AircraftType> AircraftTypes = new List<AircraftType>
        {
            new AircraftType { Id = 1,CarryingCapacity = 47000,CountOfSeats = 96, Model = "Туполев Ту-134"},
            new AircraftType { Id = 2,CarryingCapacity = 72000,CountOfSeats = 158, Model = "Туполев Ту-154 "},
            new AircraftType { Id = 3,CarryingCapacity = 107900,CountOfSeats = 214, Model = "Туполев Ту-204"}
        };
        public List<Ticket> Tickets = new List<Ticket>
        {
            new Ticket {Id = 1, Number = "AH101", Price = 100},
            new Ticket {Id = 2, Number = "AH102", Price = 150},
            new Ticket {Id = 3, Number = "AH103", Price = 200},
            new Ticket {Id = 4, Number = "AH104", Price = 250},
            new Ticket {Id = 5, Number = "AH105", Price = 300},
        };
        public List<Stewardess> Stewardesses = new List<Stewardess>
        {
            new Stewardess
            {
                Id = 1,FirstName = "Inna" ,LastName  = "Vlasova",DateOfBirth = new DateTime(1991,9,17)
            },
            new Stewardess
            {
                Id = 2,FirstName = "Yana" ,LastName = "Vlasova",DateOfBirth = new DateTime(1991,9,28),
            },
            new Stewardess
            {
                Id = 3,FirstName = "Katya" ,LastName = "Puskina",DateOfBirth = new DateTime(1987,3,13),
            }
        };
        public List<Pilot> Pilots = new List<Pilot>
        {
            new Pilot
            {
                Id = 1,FirstName = "Ivan" ,LastName = "Kotov",Experierence = 10,DateOfBirth = new DateTime(1978,6,17)
            },
            new Pilot
            {
                Id = 2,FirstName = "Oleg" ,LastName = "Ivanov",Experierence = 3,DateOfBirth = new DateTime(1987,9,27),
            }
        };
        public List<Crew> Crews = new List<Crew>
        {
            new Crew
            {
              Id = 1,
              Pilot = new Pilot
              {
                  Id = 1,FirstName = "Ivan" ,LastName = "Kotov",Experierence = 10,DateOfBirth = new DateTime(1978,6,17)
              },
              Stewardesses = new List<Stewardess>
              {
                  new Stewardess
                  {
                      Id = 1,FirstName = "Inna" ,LastName  = "Vlasova",DateOfBirth = new DateTime(1991,9,17)
                  },
                  new Stewardess
                  {
                      Id = 2,FirstName = "Yana" ,LastName = "Vlasova",DateOfBirth = new DateTime(1991,9,28),
                  },
              }
            }
        };
        public List<Departures> Departureses = new List<Departures>
        {
            new Departures
            {
                Id = 1,Number = "AH95",DepartureTime = new DateTime(2018,6,26),
                Aircraft = new Aircraft {Id = 1,
                    ReleseDate = new DateTime(2008,6,15),
                    Name = "Lastochka" ,
                    Lifetime = DateTime.Now - DateTime.Parse("2008/6/15"),
                    Type =  new AircraftType { Id = 3,CarryingCapacity = 107900,CountOfSeats = 214, Model = "Туполев Ту-204"}},
                Crew =  new Crew
                {
                    Id = 1,
                    Pilot = new Pilot
                    {
                        Id = 1,FirstName = "Ivan" ,LastName = "Kotov",Experierence = 10,DateOfBirth = new DateTime(1978,6,17)
                    },
                    Stewardesses = new List<Stewardess>
                    {
                        new Stewardess
                        {
                            Id = 1,FirstName = "Inna" ,LastName  = "Vlasova",DateOfBirth = new DateTime(1991,9,17)
                        },
                        new Stewardess
                        {
                            Id = 2,FirstName = "Yana" ,LastName = "Vlasova",DateOfBirth = new DateTime(1991,9,28),
                        },
                    }
                }
            }
        };
        public List<Flight> Flights = new List<Flight>
        {
            new Flight
            {
                Id = 1,Number = "107",PointOfDeparture = "London",Destination = "Paris",DepartureTime = DateTime.Now,
                ArrivelTime = DateTime.Now,
                Ticket = new List<Ticket>
                {
                    new Ticket {Id = 1, Number = "AH101", Price = 100},
                    new Ticket {Id = 2, Number = "AH102", Price = 150},
                    new Ticket {Id = 3, Number = "AH103", Price = 200},
                    new Ticket {Id = 4, Number = "AH104", Price = 250},
                    new Ticket {Id = 5, Number = "AH105", Price = 300},
                }
            }
        };
    }
}
