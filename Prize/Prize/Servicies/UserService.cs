using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Prize.data;
using Prize.Models;
 

namespace Prize.Servicies
{
    public class UserService : IUserService
    {
        private readonly ElPrizeContext _context;
        public UserService(ElPrizeContext context )
        {
            _context = context;
             
        }

        public async Task<User> Authenticate(LoginViewModel model)
        {
            User user = GetUser(model);
            
            return user;
        }


        private User GetUser(LoginViewModel model)
        {
            User user = new User();
            user = _context.Users.Where(c => c.Username == model.Username).Where(a => a.Password == model.Password ).First();


            return user;
        }


    }
}
