using System.Collections.Generic;

namespace Airport_REST_API.DataAccess.Models
{
    public class Crew
    {
        public Pilot Pilot { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
    }
}
