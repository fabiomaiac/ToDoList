using Microsoft.EntityFrameworkCore;
using ToDo.Data.Context;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Models;

namespace ToDo.Data.Repository
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ToDoContext context) : base(context)
        {
            
        }
        public async Task<UserEntity> GetEmail(string email)
        {
           return await _dataSet.Where(x => x.Email.ToUpper().Equals(email.ToUpper())).FirstOrDefaultAsync();
        }

        public async Task<UserEntity> Login(string email, string senha)
        {
            return await _dataSet.Where(x => x.Email.ToUpper().Equals(email.ToUpper()) && x.Senha.Equals(senha)).FirstOrDefaultAsync();
        }
    }
}