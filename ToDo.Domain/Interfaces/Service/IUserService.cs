using ToDo.Domain.Dto.User;
using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Service
{
    public interface IUserService
    {
       public Task<UserResponseDto> Login (UserLoginDto user);
       public Task<UserResponseDto> Insert (UserInsertDto user);
       public Task<UserResponseDto> Update (UserEntity user);
       public Task<UserResponseDto> GetById (int id);
       public Task<UserResponseDto> GetByEmail (string email);

    }
}