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
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL TRANSACTION DATA
        [HttpGet("{UserId}")]
        public async Task<ActionResult<IEnumerable<GetTransactionResult>>> Get(Guid UserId)
        {
            var transaction = await _context.Transaction
            .Where(x => x.UserId == UserId)
            .OrderBy(x => x.TransactionDate)
            .Select(x => new GetTransactionResult()
            {
                TransactionId = x.TransactionId,
                TransactionStatus = x.TransactionStatus,
                TransactionDate = x.TransactionDate,
                TotalTicket = x.TotalTicket,
                TotalPrice = x.TotalPrice,
                User = x.User,
                Theater = x.Theater,
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

        // CREATE NEW TRANSACTION
        [Route("api/CreateTransaction")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTransactionRequest createTransactionRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var transaction = new Transaction
            {
                TransactionDate = createTransactionRequest.TransactionDate,
                TransactionStatus = createTransactionRequest.TransactionStatus,
                TotalTicket = createTransactionRequest.TotalTicket,
                TotalPrice = createTransactionRequest.TotalPrice,
                User = createTransactionRequest.User,
                Theater = createTransactionRequest.Theater,
                PaymentMethod = createTransactionRequest.PaymentMethod
            };

            _context.Transaction.Add(transaction);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
