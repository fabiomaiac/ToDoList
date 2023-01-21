using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Domain.Dto.User;
using ToDo.Domain.Enums;
using ToDo.Domain.Models;

namespace ToDo.Domain.Dto.ToDo
{
    public class ToDoResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public StatusToDoEnum StatusToDoEnum { get; set; }
        public string Descricao { get; set; }
        public UserResponseDto User { get; set; }
    }
}