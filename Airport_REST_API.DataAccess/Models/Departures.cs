﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Airport_REST_API.DataAccess.Models
{
    public class Departures
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        [RegularExpression("^(0[1-9]|1[0-9])-(0[1-9]|[12][0-9]|3[01])-(19|20)[0-9][0-9]$")]
        public DateTime DepartureTime { get; set; }
        [Required]
        public Crew Crew { get; set; }
        [Required]
        public Aircraft Aircraft { get; set; }
    }
}
