namespace Sunibpolis_backend.Models.Result
{
    public class GetTicketResult
    {
        public int TicketId { get; set; }
        public int TicketPrice { get; set; }
        public int TotalTicket { get; set; }
        public CinemaLocation CinemaLocation { get; set; }
    }
}
