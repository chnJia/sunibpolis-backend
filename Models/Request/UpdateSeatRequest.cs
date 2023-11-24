using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class UpdateSeatRequest
    {
        [Required]
        [MaxLength(10)]
        public string SeatStatus { get; set; }
    }
}
