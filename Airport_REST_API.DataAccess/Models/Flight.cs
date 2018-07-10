using System;

namespace Airport_REST_API.Models
{
    public class Flight
    {
        public string Number { get; set; }
        public string PointOfDeparture { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivelTime { get; set; }
        public Ticket Ticket { get; set; }
    }
}
