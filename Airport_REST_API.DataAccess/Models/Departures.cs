using System;


namespace Airport_REST_API.DataAccess.Models
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
