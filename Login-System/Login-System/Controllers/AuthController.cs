using Login_System.Entities;
using Login_System.Models;
using Login_System.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Login_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDTO request)
        {
            var created = await _authService.RegisterAsync(request);

            if (!created)
                return BadRequest("Username already exists.");

            return Ok("User registered.");
        }

        // GET /api/Auth/login?username=x&password=y
        [HttpGet("login")]
        public async Task<ActionResult<string>> Login([FromQuery] UserDTO request)
        {
            var token = await _authService.LoginAsync(request);

            if (token is null)
                return BadRequest("Invalid username or password.");

            return Ok(token); // (string) JWT token
        }
    }
}
