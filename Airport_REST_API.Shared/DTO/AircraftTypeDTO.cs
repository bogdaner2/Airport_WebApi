using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class AircraftTypeDTO
    {
        [Required]
        public int Id { get; set; }
        public string Model { get; set; }
        public int CountOfSeats { get; set; }
        public int CarryingCapacity { get; set; }
    }
}
