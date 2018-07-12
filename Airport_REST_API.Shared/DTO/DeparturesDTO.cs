using System;

namespace Airport_REST_API.Shared.DTO
{
    public class DeparturesDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string DepartureTime { get; set; }
        public int CrewId { get; set; }
        public int AircraftId { get; set; }
    }
}
