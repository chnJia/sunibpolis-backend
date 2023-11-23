using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class Seat
    {
        [Key]
        public int seatId { get; set; }
        public char seatName { get; set; }
        public int seatNumber { get; set; }
        [MaxLength(10)]
        public string seatStatus { get; set; }

    }
}
