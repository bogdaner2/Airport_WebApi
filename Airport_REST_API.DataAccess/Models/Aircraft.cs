using System;

namespace Airport_REST_API.DataAccess.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AircraftType Type { get; set; }
        public DateTime ReleseDate { get; set; }
        public TimeSpan Lifetime { get; set; }
    }
}
