using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Sunibpolis_backend.Models
{
    public class GetPaymentMethod
    {
        public int PaymentMethodId { get; set; }

        public string PaymentMethodType { get; set; }

        public string PaymentMethodName { get; set; }


    }
}
