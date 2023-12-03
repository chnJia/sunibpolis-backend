using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }

        [MaxLength(10)]
        public string TransactionStatus { get; set; }

        public int TotalTicket { get; set; }
        public int TotalPrice { get; set; }

        /*
        // User Info
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public string UserPhoneNumber { get; set; }
        public int UserAge {  get; set; }

        // Theater Info
        public int TheaterId { get; set; }
        public string TheaterType { get; set; }
        public string TheaterName { get; set; }
        public int TicketPrice { get; set; }

        // PaymentMethod info
        public int PaymentMethodId { get; set; }
        public string PaymentMethodType { get; set; }

        public string PaymentMethodName { get; set; }
        */

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Theater")]
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }

        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
    }
}
