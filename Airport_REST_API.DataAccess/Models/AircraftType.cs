﻿namespace Airport_REST_API.DataAccess.Models
{
    public class AircraftType
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int CountOfSeats { get; set; }
        public int CarryingCapacity { get; set; }
    }
}
