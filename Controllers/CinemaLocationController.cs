using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models;
using Sunibpolis_backend.Models.Request;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaLocationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CinemaLocationController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL SEAT DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCinemaLocationResult>>> Get()
        {
            var seat = await _context.CinemaLocation
            .OrderBy(x => x.CinemaLocationName)
            .Select(x => new GetCinemaLocationResult()
            {
                CinemaLocationId = x.CinemaLocationId,
                CinemaLocationName = x.CinemaLocationName,
                City = x.City

            })
               .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetCinemaLocationResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = seat
            };
            return Ok(response);
        }
    }
}