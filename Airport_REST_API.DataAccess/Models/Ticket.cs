namespace Airport_REST_API.DataAccess.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int DepartureId { get; set; }
        public double Price { get; set; }
        public string Number { get; set; }
    }
}
