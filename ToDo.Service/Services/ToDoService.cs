using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ToDo.Domain.Dto.ToDo;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Service.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IMapper _mapper;
        private readonly IToDoRepository _repo;
        public ToDoService(IToDoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public string Delete(int Id)
        {
            _repo.Delete(Id);

            return "Apagado com sucesso";
        }

        public async Task<List<ToDoResponseDto>> GetAllUserId(int userId)
        {
            var listToDo = await _repo.GetToDoUser(userId);
            return _mapper.Map<List<ToDoResponseDto>>(listToDo);
        }


        public async Task<ToDoResponseDto> GetById(int Id)
        {
            ToDoEntity todo = await _repo.GetById(Id);
            return _mapper.Map<ToDoResponseDto>(todo);
        }

        public string Insert(ToDoInsertDto item)
        {
           _repo.Insert( _mapper.Map<ToDoEntity>(item));

           return "Salvo com sucesso";
        }
    }
}