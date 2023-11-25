using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class Theater
    {
        [Key]
        public int TheaterId { get; set; }
        public string TheaterType { get; set; }
        public string TheaterName { get; set; }
        public int TicketPrice { get; set; }

        [ForeignKey("Seat")]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        [ForeignKey("MovieShowTime")]
        public int MovieShowTimeId { get; set; }
        public MovieShowTime MovieShowTime { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public ICollection<CinemaLocation> CinemaLocation { get; set; }

    }
}
