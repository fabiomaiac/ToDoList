using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Dto.User
{
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<ToDoEntity> ToDos { get; set; }

    }
}