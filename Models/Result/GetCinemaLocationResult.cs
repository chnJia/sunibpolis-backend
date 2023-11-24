namespace Sunibpolis_backend.Models.Result
{
    public class GetCinemaLocationResult
    {
        public int CinemaLocationId { get; set; }
        public string CinemaLocationName { get; set; }
        public City City { get; set; }
        public Theater Theater { get; set; }
    }
}
