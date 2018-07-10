using System;

namespace Airport_REST_API.Models
{
    public class AircraftDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AircraftTypeDTO Type { get; set; }
        public DateTime ReleseDate { get; set; }
        public TimeSpan Lifetime { get; set; }
    }
}
