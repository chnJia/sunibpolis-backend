namespace Sunibpolis_backend.Models.Result
{
    public class GetSeatResult
    {
        public int SeatId { get; set; }
        public string SeatName { get; set; }
        public int SeatNumber { get; set; }
        public string SeatStatus { get; set; }
        public Theater Theater { get; set; }

    }
}
