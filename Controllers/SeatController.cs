using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SeatController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL SEAT DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetSeatResult>>> Get()
        {
            var seat = await _context.Seat
            .OrderBy(x => x.SeatName)
            .Select(x => new GetSeatResult()
            {
                SeatId = x.SeatId,
                SeatName = x.SeatName,
                SeatNumber = x.SeatNumber,
                SeatStatus = x.SeatStatus
            })
               .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetSeatResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = seat
            };
            return Ok(response);
        }
    }
}
