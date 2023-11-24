using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    public class CityController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CityController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL CITY DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCityResult>>> Get()
        {
            var city = await _context.City
                .OrderBy(x => x.CityName)
                .Select(x => new GetCityResult()
                {
                    CityId = x.CityId,
                    CityName = x.CityName
                })
        .ToListAsync();
            var response = new ApiResponse<IEnumerable<GetCityResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = city
            };
            return Ok(response);
        }
    }
}
