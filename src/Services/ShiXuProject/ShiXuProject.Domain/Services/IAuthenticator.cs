using ShiXuProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiXuProject.Domain.Services
{
    public interface IAuthenticator
    {
        bool Authenticate(User user);
    }
}
