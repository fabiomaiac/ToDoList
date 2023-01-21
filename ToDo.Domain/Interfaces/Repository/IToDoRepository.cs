using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Repository
{
    public interface IToDoRepository : IBaseRepository<ToDoEntity>
    {
        public Task<List<ToDoEntity>> GetToDoUser(int userId);
    }
}