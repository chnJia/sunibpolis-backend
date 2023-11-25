using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class CinemaLocation
    {
        [Key]
        public int CinemaLocationId { get; set; }
        [MaxLength(50)]
        public string CinemaLocationName { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Theater> Theater { get; set; }

    }
}
