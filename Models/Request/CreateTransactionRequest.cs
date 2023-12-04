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
        public Guid UserId { get; set; }
        public string TheaterName { get; set; }
        public string SeatName { get; set; }
        public string MovieName { get; set; }
        public string CinemaLocationName { get; set; }
        public string PaymentMethodName { get; set; }
    }
}
