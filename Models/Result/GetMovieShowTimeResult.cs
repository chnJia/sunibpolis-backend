namespace Sunibpolis_backend.Models.Result
{
    public class GetMovieShowTimeResult
    {
        public int MovieShowTimeId { get; set; }
        public DateTime MovieShowTime { get; set; }
        public Theater Theater { get; set; }

    }
}