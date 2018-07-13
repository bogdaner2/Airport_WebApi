using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.DataAccess.Models
{
    public class Ticket
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(0.0,4000.0)]
        public double Price { get; set; }
        [Required]
        [MinLength(4)]
        public string Number { get; set; }
    }
}
