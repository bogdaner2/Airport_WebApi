using System;

namespace Airport_REST_API.Shared.DTO
{
    public class DeparturesDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public CrewDTO Crew { get; set; }
        public AircraftDTO Aircraft { get; set; }
    }
}
