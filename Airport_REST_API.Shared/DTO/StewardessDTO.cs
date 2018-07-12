using System;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class StewardessDTO
    {
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastSurname { get; set; }
        public string DateOfBirth { get; set; }
    }
}
