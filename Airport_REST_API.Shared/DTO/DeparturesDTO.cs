using System;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class DeparturesDTO
    {
        [Required]
        public int Id { get; set; }
        public string Number { get; set; }
        public string DepartureTime { get; set; }
        [Required]
        public int CrewId { get; set; }
        [Required]
        public int AircraftId { get; set; }
    }
}
