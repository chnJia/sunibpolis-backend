using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models.Request
{
    public class CreateMovieShowTime
    {
        [Required]
        public DateTime MovieShowTime { get; set; }

    }
}