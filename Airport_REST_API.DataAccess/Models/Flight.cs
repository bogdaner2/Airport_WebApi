using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.DataAccess.Models
{
    public class Flight
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[A-Z]{3}[1-9]{3}$", ErrorMessage = "Format - AAA000")]
        public string Number { get; set; }
        [Required]
        [MinLength(3)]
        public string PointOfDeparture { get; set; }
        [Required]
        [RegularExpression("^(0[1-9]|1[0123456789])-(0[1-9]|[12][0-9]|3[01])-(19|20)[0-9][0-9]$", ErrorMessage = "Format - 01/01/2018")]
        public DateTime DepartureTime { get; set; }
        [Required]
        [MinLength(3)]
        public string Destination { get; set; }
        [Required]
        [RegularExpression("^(0[1-9]|1[0123456789])-(0[1-9]|[12][0-9]|3[01])-(19|20)[0-9][0-9]$", ErrorMessage = "Format - 01/01/2018 1")]
        public DateTime ArrivalTime { get; set; }
        [Required]
        public List<Ticket> Ticket { get; set; }
    }
}
