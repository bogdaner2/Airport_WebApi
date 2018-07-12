using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.Shared.DTO
{
    public class AircraftDTO
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int TypeId { get; set; }
        public string ReleseDate { get; set; }
        public string Lifetime { get; set; }
    }
}
