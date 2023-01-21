using Microsoft.EntityFrameworkCore;
using ToDo.Data.Context;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Models;

namespace ToDo.Data.Repository
{
    public class ToDoRepository : BaseRepository<ToDoEntity>, IToDoRepository
    {
        public ToDoRepository(ToDoContext context) : base(context)
        {
        }

        public async Task<List<ToDoEntity>> GetToDoUser(int userId)
        {
           return await _dataSet.Where(x => x.UserId == userId).Include(x => x.User).ToListAsync();
        }
    }
}