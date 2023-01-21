using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Repository
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
       public Task<UserEntity> GetEmail(string email);
       public Task<UserEntity> Login (string email, string senha);  
    }
}