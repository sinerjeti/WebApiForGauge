using Microsoft.AspNetCore.Mvc;
using WebApiForGauge.Database;
using WebApiForGauge.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiForGauge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationContext _context;

        public UserController(ApplicationContext context)
        {
            _context = context;
        }
        
        [HttpGet("checkuserexist")]
        public async Task<IActionResult> CheckUserExist([FromBody] User request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);

            if (user != null) return Ok();
            else return NotFound();
        }

        [HttpGet("checkpassword")]
        public async Task<IActionResult> CheckPassword([FromBody] User request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);

            if (user != null && user.Password == request.Password) return Ok();
            else return BadRequest();
        }

        [HttpPost("createuser")]
        public async Task<IActionResult> CreateUser([FromBody] User request)
        {   
            var user = new User
            {
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok();
        }
        
        [HttpDelete("deleteuser")]
        public async Task<IActionResult> DeleteUser([FromBody] User request)
        {
            var user = _context.Users.FirstOrDefault(u => u.PhoneNumber == request.PhoneNumber);
            if (user != null) _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
