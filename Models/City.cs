using System.ComponentModel.DataAnnotations;

namespace Sunibpolis_backend.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [MaxLength(50)]
        public string CityName { get; set; }

        public ICollection<CinemaLocation> CinemaLocation { get; set; }
    }
}
