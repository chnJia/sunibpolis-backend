using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Sunibpolis_backend.Models
{
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodId { get; set; }

        [MaxLength(10)]
        public string PaymentMethodtype { get; set; }

        [MaxLength(10)]
        public String PaymentMethodName { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }
}
