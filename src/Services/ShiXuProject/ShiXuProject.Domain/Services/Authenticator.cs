using ShiXuProject.Domain.Entities;
using ShiXuProject.Domain.Services;

namespace ShiXuProject.Domain
{
    public class Authenticator : IAuthenticator
    {
        public bool Authenticate(User user)
        {
            return user.Username == "admin" && user.Password == "admin";
        }
    }
}
