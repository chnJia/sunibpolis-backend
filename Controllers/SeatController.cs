using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Request;
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
                SeatStatus = x.SeatStatus,
                Theater = x.Theater
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int SeatId, [FromBody] UpdateSeatRequest UpdateSeatRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var seat = await _context.Seat.FirstOrDefaultAsync(s => s.SeatId == SeatId);

            if (seat.SeatStatus == "Occupied")
            {
                return NotFound("Seat has been taken");
            }

            if (seat.SeatId != seat.SeatId)
            {
                return BadRequest("SeatId in the request body does not match the route parameter");
            }

            UpdateSeatRequest.SeatStatus = "Occupied";

            seat.SeatStatus = UpdateSeatRequest.SeatStatus;

            await _context.SaveChangesAsync();
            return Ok();
        }
        
    }
}
