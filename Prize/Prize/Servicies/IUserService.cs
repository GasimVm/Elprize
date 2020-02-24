using Prize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Servicies
{
    public interface IUserService
    {
        Task<User> Authenticate(LoginViewModel model);
    }
}
