using System.Collections.Generic;

namespace Airport_REST_API.Models
{
    public class Crew
    {
        public Pilot Pilot { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
    }
}
