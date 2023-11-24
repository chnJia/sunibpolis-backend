using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL TRANSACTION DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetTransactionResult>>> Get()
        {
            var transaction = await _context.Transaction
            .OrderBy(x => x.TransactionDate)
            .Select(x => new GetTransactionResult()
            {
                TransactionId = x.TransactionId,
                TransactionStatus = x.TransactionStatus,
                TotalPrice = x.TotalPrice,
                TransactionDate = x.TransactionDate,
                User = x.User,
                Ticket = x.Ticket,
                PaymentMethod = x.PaymentMethod
            })
            .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetTransactionResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = transaction
            };
            return Ok(response);
        }
    }
}
