using System;

namespace Airport_REST_API.DataAccess.Models
{
    public class Stewardess
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
