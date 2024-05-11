using LogInProject.Application.DTOs;
using LogInProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public Task<List<UserDTO>> GetUserInfos()
        {
            throw new NotImplementedException();
        }
    }
}
