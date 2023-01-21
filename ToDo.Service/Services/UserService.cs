using AutoMapper;
using ToDo.Domain.Dto.User;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<UserResponseDto> GetByEmail(string email)
        {
            var userDb = await _repo.GetEmail(email);
            
            return _mapper.Map<UserResponseDto>(userDb); 
        }

        public async Task<UserResponseDto> GetById(int id)
        {
            var user = await _repo.GetById(id);

            return _mapper.Map<UserResponseDto>(user);
;
        }

        public async Task<UserResponseDto> Insert(UserInsertDto user)
        {
            var userDb = await _repo.GetEmail(user.Email);

             if(userDb != null)
                throw new Exception("Usuário existente");
             
            var userMap = _mapper.Map<UserEntity>(user);
            _repo.Insert(userMap);

            return _mapper.Map<UserResponseDto>(userMap);
        }

        public Task<UserResponseDto> Login(UserLoginDto user)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponseDto> Update(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}