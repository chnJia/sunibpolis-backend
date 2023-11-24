using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class CreatePaymentMethodRequest
    {

        [Required]
        public int PaymentMethodId { get; set; }

        [Required]
        [MaxLength(10)]
        public string PaymentMethodType { get; set; }

        [Required]
        [MaxLength(10)]
        public String PaymentMethodName { get; set; }

    }
}
