using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Request;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMovieResult>>> Get()
        {
            var movie = await _context.Movie
            .OrderBy(x => x.MovieId)
            .Select(x => new GetMovieResult()
            {
                MovieId = x.MovieId,
                MovieName = x.MovieName,
                MovieGenre = x.MovieGenre,
                MovieType = x.MovieType,
                MovieAgeRating = x.MovieAgeRating,
                MovieDurationTime = x.MovieDurationTime,
                MovieDescription = x.MovieDescription,
                MovieImg = x.MovieImg
            })
               .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetMovieResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = movie
            };
            return Ok(response);
        }
    }
}
