﻿using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.DataAccess.Models
{
    public class AircraftType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [Range(5,500)]
        public int CountOfSeats { get; set; }
        [Required]
        [Range(5000, 500000)]
        public int CarryingCapacity { get; set; }
    }
}
