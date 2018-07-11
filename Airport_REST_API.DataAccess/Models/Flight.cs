using System;
using System.Collections.Generic;

namespace Airport_REST_API.DataAccess.Models
{
    public class Flight
    {
        public string Number { get; set; }
        public string PointOfDeparture { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivelTime { get; set; }
        public List<Ticket> Ticket { get; set; }
    }
}
