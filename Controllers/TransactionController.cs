using Microsoft.AspNetCore.Mvc;
using Sunibpolis_backend.Data;

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
    }
}
