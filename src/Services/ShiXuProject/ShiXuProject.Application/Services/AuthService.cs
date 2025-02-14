using ShiXuProject.Domain.Entities;
using ShiXuProject.Domain.Services;

namespace ShiXuProject.Application.Services
{
    public class AuthService
    {
        private readonly IAuthenticator _authenticator;

        public AuthService(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
        }

        public string Login(string username, string password)
        {
            var user = new User(username, password);
            return _authenticator.Authenticate(user) ? "/authenticated" : "/loginfailed";
        }
    }
}
