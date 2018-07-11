using System;

namespace Airport_REST_API.DataAccess.Models
{
    public class Stewardess
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
