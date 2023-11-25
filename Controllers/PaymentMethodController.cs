using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Data;
using Sunibpolis_backend.Models;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMenthodController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PaymentMenthodController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL SEAT DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetPaymentMethodResult>>> Get()
        {
            var seat = await _context.PaymentMethod
            .OrderBy(x => x.PaymentMethodId)
            .Select(x => new GetPaymentMethodResult()
            {
                PaymentMethodId = x.PaymentMethodId,
                PaymentMethodType = x.PaymentMethodType,
                PaymentMethodName = x.PaymentMethodName

            })
               .ToListAsync();

            var response = new ApiResponse<IEnumerable<GetPaymentMethodResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = seat
            };
            return Ok(response);
        }
    }
}