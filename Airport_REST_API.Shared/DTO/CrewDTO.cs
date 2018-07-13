using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class CrewDTO
    {
        [Required]
        [Range(1, Int32.MaxValue)]
        public int? Id { get; set; }

        [Required]
        public int PilotId { get; set; }

        [Required]
        public List<int> StewardessesId { get; set; }
    }
}
