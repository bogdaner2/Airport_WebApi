using System.Collections.Generic;

namespace Airport_REST_API.Shared.DTO
{
    public class CrewDTO
    {
        public int PilotId { get; set; }
        public List<int> StewardessesId { get; set; }
    }
}
