namespace Sunibpolis_backend.Models.Result
{
    public class GetTheaterResult
    {
        public int TheaterId { get; set; }
        public string TheaterType { get; set; }
        public string TheaterName { get; set; }
        public int TicketPrice { get; set; }
        public CinemaLocation CinemaLocation { get; set; }
        public Movie Movie { get; set; }

    }
}
