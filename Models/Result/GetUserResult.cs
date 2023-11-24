using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Result
{
    public class GetUserResult
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public int UserAge { get; set; }

    }
}
