using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class CinemaLocation
    {
        [Key]
        public int CinemaLocationId {  get; set; }
        [MaxLength(50)]
        public string CinemaLocationName { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City city { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("Theater")]
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

    }
}
