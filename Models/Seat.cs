using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        public char SeatName { get; set; }
        public int SeatNumber { get; set; }
        [MaxLength(10)]
        public string SeatStatus { get; set; }

        public ICollection<Theater> Theaters { get; set; }

    }
}
