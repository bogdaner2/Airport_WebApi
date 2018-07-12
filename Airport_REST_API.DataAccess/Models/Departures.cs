﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Airport_REST_API.DataAccess.Models
{
    public class Departures
    {
        [Required]
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public Crew Crew { get; set; }
        public Aircraft Aircraft { get; set; }
    }
}
