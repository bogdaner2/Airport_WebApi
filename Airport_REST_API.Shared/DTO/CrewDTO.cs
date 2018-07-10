using System.Collections.Generic;

namespace Airport_REST_API.Shared.DTO
{
    public class CrewDTO
    {
        public PilotDTO Pilot { get; set; }
        public List<StewardessDTO> Stewardesses { get; set; }
    }
}
