using System.Collections.Generic;

namespace Airport_REST_API.DataAccess.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public Pilot Pilot { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
    }
}
