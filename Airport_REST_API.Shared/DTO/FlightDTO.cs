using System;
using System.Collections.Generic;

namespace Airport_REST_API.Shared.DTO
{
    public class FlightDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string PointOfDeparture { get; set; }
        public string DepartureTime { get; set; }
        public string Destination { get; set; }
        public string ArrivelTime { get; set; }
        public List<int> TicketsId { get; set; }
    }
}
