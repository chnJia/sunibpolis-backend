using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [ForeignKey("Theater")]
        public int Theaterid { get; set; }
        public Theater Theater { get; set; }
      
        public ICollection<Transaction> Transaction { get; set; }

    }
}
