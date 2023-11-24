using Microsoft.AspNetCore.Mvc;
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
       // public async Task<IActionResult<IEnumerable<GetSeatResult>>
    }
}
