using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class MovieShowTime
    {
        [Key]
        public int MovieShowTimeId { get; set; }

        public DateTime ShowTime { get; set; }

        public ICollection<Theater> Theaters { get; set; }

    }
}
