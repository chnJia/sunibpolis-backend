using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [MaxLength(50)]
        public string MovieName { get; set; }

        [MaxLength(50)]
        public string MovieGenre { get; set; }

        [MaxLength(50)]
        public string MovieType { get; set; }

        [MaxLength(50)]
        public string MovieAgeRating { get; set; }

        public int MovieDurationTime { get; set; }

        [MaxLength(50)]
        public string MovieDescription { get; set; }

        public ICollection<CinemaLocation> CinemaLocation { get; set; }

    }
}
