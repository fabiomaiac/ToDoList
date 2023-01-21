using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Domain.Dto.User
{
    public class UserInsertDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}