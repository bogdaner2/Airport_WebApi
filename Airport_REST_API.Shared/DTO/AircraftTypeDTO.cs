namespace Airport_REST_API.Models
{
    public class AircraftTypeDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int CountOfSeats { get; set; }
        public int CarryingCapacity { get; set; }
    }
}
