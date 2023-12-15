using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class CreateTransactionRequest
    {
        public DateTime TransactionDate { get; set; }

        [MaxLength(10)]
        public string TransactionStatus { get; set; }

        public int TotalTicket { get; set; }
        public int TotalPrice { get; set; }
        public User User { get; set; }

        public Theater Theater { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
