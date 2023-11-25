using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class MovieShowTime
    {
        [Key]
        public int MovieShowTimeId { get; set; }

        public DateTime ShowTime { get; set; }

        [ForeignKey("MovieShowTime")]
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }

    }
}
