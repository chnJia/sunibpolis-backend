using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class Theater
    {
        [Key]
        public int TheaterId { get; set; }
        public string TheaterType { get; set; }
        public string TheaterName { get; set;}

        [ForeignKey("Seat")]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        public ICollection<CinemaLocation> CinemaLocation { get; set; }
    }
}
