using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class CrewDTO
    {
        [Required]
        public int PilotId { get; set; }
        [Required]
        public List<int> StewardessesId { get; set; }
    }
}
