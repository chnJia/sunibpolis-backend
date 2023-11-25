using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterController : ControllerBase
    {

        private readonly AppDbContext _context;

        public TheaterController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL THEATER DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetTheaterResult>>> Get()
        {
            var theater = await _context.Theater
            .OrderBy(x => x.TheaterName)
            .Select(x => new GetTheaterResult()
            {
                TheaterId = x.TheaterId,
                TheaterType = x.TheaterType,
                TheaterName = x.TheaterName,
                TicketPrice = x.TicketPrice,
                CinemaLocation = x.CinemaLocation,
                Movie = x.Movie

            })
            .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetTheaterResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = theater
            };
            return Ok(response);
        }
    }
}
