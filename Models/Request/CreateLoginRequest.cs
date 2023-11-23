using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class CreateLoginRequest
    {
        [Required]
        [MaxLength(50)]
        public string UserEmail { get; set; }

        [Required]
        [MaxLength(13)]
        public string UserPassword { get; set; }
    }
}
