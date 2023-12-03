using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Request;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieShowTimeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MovieShowTimeController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL SEAT DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMovieShowTimeResult>>> Get()
        {
            var movieShowTime = await _context.MovieShowTime
            .OrderBy(x => x.ShowTime)
            .Select(x => new GetMovieShowTimeResult()
            {
                MovieShowTimeId = x.MovieShowTimeId,
                ShowTime = x.ShowTime,
                Theater = x.Theater

            })
               .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetMovieShowTimeResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = movieShowTime
            };
            return Ok(response);
        }
    }
}