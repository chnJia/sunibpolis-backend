using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Result
{
    public class GetTransactionResult
    {
        public int TransactionId { get; set; }
        public string TransactionStatus { get; set; }
        public int TotalPrice { get; set; }
        public int TotalTicket { get; set; }
        public DateTime TransactionDate { get; set; }
        public User User { get; set; }
        public Ticket Ticket { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }

}
