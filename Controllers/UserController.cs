using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Models;
using Sunibpolis_backend.Models.Request;
using Sunibpolis_backend.Models.Result;

namespace Sunibpolis_backend.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL USER DATA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUserResult>>> Get()
        {
            var user = await _context.User
                .OrderBy(x => x.UserName)
                .Select(x => new GetUserResult()
                {
                    UserId = x.UserId,
                    UserName = x.UserName,
                    UserEmail = x.UserEmail,
                    UserPhoneNumber = x.UserPhoneNumber,
                    UserPassword = x.UserPassword,
                    UserAge = x.UserAge
                })
        .ToListAsync();
            var response = new ApiResponse<IEnumerable<GetUserResult>>
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = user
            };
            return Ok(response);
        }


        // POST CHECK LOGIN USER
        [Route("api/User/login")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateLoginRequest createLoginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkEmail = await _context.User.FirstOrDefaultAsync(
                x => x.UserEmail == createLoginRequest.UserEmail
            );

            if (checkEmail == null)
            {
                return NotFound("Email Not Found");
            }

            if (checkEmail.UserPassword != createLoginRequest.UserPassword)
            {
                return Unauthorized("Invalid Password");
            }

            // login success
            return Ok("Login Successful");
        }

        // POST CHECK REGISTER USER
        [Route("api/User/register")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSignUpRequest createSignUpRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkEmail = await _context.User.FirstOrDefaultAsync(
                x => x.UserEmail == createSignUpRequest.UserEmail
            );

            if (checkEmail != null)
            {
                return Conflict("Email has been taken, please use another email");
            }

            var checkPassword = await _context.User.FirstOrDefaultAsync(
                x => x.UserPassword == createSignUpRequest.UserPasswod
            );

            if (checkPassword != null)
            {
                return Conflict("Password has been taken, please use another password");
            }

            var checkPhoneNum = await _context.User.FirstOrDefaultAsync(
                x => x.UserPhoneNumber == createSignUpRequest.UserPhoneNumber
            );

            if (checkPhoneNum != null)
            {
                return Conflict("Phone number has been taken, please use another phone number");
            }

            var user = new User
            {
                UserName = createSignUpRequest.UserName,
                UserEmail = createSignUpRequest.UserEmail,
                UserPassword = createSignUpRequest.UserPasswod,
                UserPhoneNumber = createSignUpRequest.UserPhoneNumber,
                UserAge = createSignUpRequest.UserAge
            };

            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
