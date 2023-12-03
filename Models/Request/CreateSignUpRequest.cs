using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class CreateSignUpRequest
    {
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserEmail { get; set; }

        [Required]
        [MaxLength(13)]
        public string UserPhoneNumber { get; set; }

        [Required]
        [MaxLength(13)]
        public string UserPassword { get; set; }

        [Required]
        public int UserAge { get; set; }

    }
}
