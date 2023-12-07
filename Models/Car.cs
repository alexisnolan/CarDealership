using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public int Mileage { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime DateSold { get; set; }
        public string Status { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
}
