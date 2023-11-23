using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int TicketPrice { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

        [ForeignKey("CinemaLocation")]
        public int CinemaLocationId { get; set; }
        public CinemaLocation CinemaLocation { get; set; }



    }
}
