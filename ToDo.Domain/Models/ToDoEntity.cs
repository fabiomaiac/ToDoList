using ToDo.Domain.Enums;

namespace ToDo.Domain.Models
{
    public class ToDoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public StatusToDoEnum StatusToDoEnum { get; set; }
        public string Descricao { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}