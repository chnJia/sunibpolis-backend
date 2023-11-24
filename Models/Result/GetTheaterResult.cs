namespace Sunibpolis_backend.Models.Result
{
    public class GetTheaterResult
    {
        public int TheaterId { get; set; }
        public string TheaterType { get; set; }
        public string TheaterName { get; set; }
        public Seat Seat { get; set; }       
        public MovieShowTime MovieShowTime { get; set; }
        public Movie Movie { get; set; }
    }
}
