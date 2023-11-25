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

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("CinemaLocation")]
        public int CinemaLocationId { get; set; }
        public CinemaLocation CinemaLocation { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
        public ICollection<MovieShowTime> MovieShowTime { get; set; }
        public ICollection<Seat> Seat { get; set; }

    }
}
