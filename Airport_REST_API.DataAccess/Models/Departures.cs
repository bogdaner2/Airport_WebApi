using System;
using Airport_REST_API.Models;

namespace Airport_REST_API.Models
{
    public class Departures
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public Crew Crew { get; set; }
        public Aircraft Aircraft { get; set; }
    }
}
