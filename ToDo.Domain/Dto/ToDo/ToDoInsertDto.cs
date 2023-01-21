using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Domain.Dto.ToDo
{
    public class ToDoInsertDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int UserId { get; set; }
       
    }
}