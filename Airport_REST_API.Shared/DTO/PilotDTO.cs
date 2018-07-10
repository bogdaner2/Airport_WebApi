using System;

namespace Airport_REST_API.Shared.DTO
{
    public class PilotDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Experierence { get; set; }
    }
}
