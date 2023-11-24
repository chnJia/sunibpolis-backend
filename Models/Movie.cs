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

<<<<<<< HEAD
        public ICollection<Theater> Theaters { get; set; }
=======
        public ICollection<Theater> Thaters { get; set; }
>>>>>>> 128ba477d1490673bb5e7cb2b8a8988a735cb8fa

    }
}
