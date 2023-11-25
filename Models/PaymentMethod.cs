using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Sunibpolis_backend.Models
{
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodId { get; set; }

        [MaxLength(10)]
        public string PaymentMethodType { get; set; }

        [MaxLength(10)]
        public string PaymentMethodName { get; set; }

        public ICollection<Transaction> Transaction { get; set; }

    }
}
