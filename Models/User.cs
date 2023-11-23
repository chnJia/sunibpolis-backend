using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string UserEmail { get; set; }

        [MaxLength(13)]
        public string UserPhoneNumber { get; set; }

        [MaxLength(13)]
        public string UserPassword { get; set; }

        public int UserAge { get; set; }

        public ICollection<Transaction> Transactions { get; set; }


    }
}
