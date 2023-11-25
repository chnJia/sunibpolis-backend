using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TicketController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL TICKET DATA 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetTicketResult>>> Get()
        {
            var ticket = await _context.Ticket
            .Include(x => x.Theater)
            .OrderBy(x => x.TicketId)
            .Select(x => new GetTicketResult()
            {
                TicketId = x.TicketId,
                Theater = x.Theater
            })
            .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetTicketResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = ticket
            };
            return Ok(response);
        }
    }
}
