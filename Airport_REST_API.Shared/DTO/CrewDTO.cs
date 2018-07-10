using System.Collections.Generic;

namespace Airport_REST_API.Models
{
    public class CrewDTO
    {
        public PilotDTO Pilot { get; set; }
        public List<StewardessDTO> Stewardesses { get; set; }
    }
}
