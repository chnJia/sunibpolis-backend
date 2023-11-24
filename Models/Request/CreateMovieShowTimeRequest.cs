using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class CreateMovieShowTimeRequest
    {
        [Required]
        [MaxLength(50)]
        public DateTime MovieShowTime { get; set; }

    }
}