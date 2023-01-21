using ToDo.Domain.Enums;

namespace ToDo.Domain.Models
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public RoleEnum Role { get; set; }
        public List<ToDoEntity> ToDos { get; set; }
    }
}