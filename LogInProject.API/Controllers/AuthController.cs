using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LogInProject.Application.Services;
using LogInProject.Core.Services;

namespace LogInProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestModel model)
        {
            // Implement logic to authenticate user
            // If authentication succeeds, generate JWT token
            var token = _authService.GenerateJwtToken(model.Username);
            return Ok(new { Token = token });
        }
    }

    public class LoginRequestModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
