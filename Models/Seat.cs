using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sunibpolis_backend.Models
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [MaxLength(5)]
        public string SeatName { get; set; }
        public int SeatNumber { get; set; }
        [MaxLength(10)]
        public string SeatStatus { get; set; }

        [ForeignKey("Theater")]
        public int TheaterId {get;set;}
        public Theater Theater {get;set;}
    

    }
}
