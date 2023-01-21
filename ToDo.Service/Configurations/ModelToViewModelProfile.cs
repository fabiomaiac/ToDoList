using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ToDo.Domain.Dto.ToDo;
using ToDo.Domain.Dto.User;
using ToDo.Domain.Models;

namespace ToDo.Service.Configurations
{
    public class ModelToViewModelProfile : Profile
    {
        public ModelToViewModelProfile()
        {
            CreateMap<UserEntity, UserLoginDto>().ReverseMap();
            CreateMap<UserEntity, UserInsertDto>().ReverseMap();
            CreateMap<UserEntity, UserResponseDto>().ReverseMap();
            CreateMap<ToDoEntity, ToDoInsertDto>().ReverseMap();
            CreateMap<ToDoEntity, ToDoResponseDto>().ReverseMap();

        }
    }
}