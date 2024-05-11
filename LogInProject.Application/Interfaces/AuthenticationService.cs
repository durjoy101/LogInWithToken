using LogInProject.Core.Services;

namespace LogInProject.Application.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly Infrastructure.Services.AuthenticationService _authenticationService;

        public AuthenticationService(Infrastructure.Services.AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public string GenerateJwtToken(string username)
        {
            return _authenticationService.GenerateJwtToken(username);
        }
    }
}
