using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.DataAccess.Models
{
    public class Ticket
    {
        [Required]
        public int Id { get; set; }
        public double Price { get; set; }
        public string Number { get; set; }
    }
}
