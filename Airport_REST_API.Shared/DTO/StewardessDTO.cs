﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class StewardessDTO
    {
        [Required]
        [Range(1,Int32.MaxValue)]
        public int? Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}
