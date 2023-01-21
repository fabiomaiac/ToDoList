using ToDo.Domain.Dto.ToDo;
using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Service
{
    public interface IToDoService 
    {
    public string Insert (ToDoInsertDto item);

    public string Delete (int Id);

    public Task<ToDoResponseDto> GetById (int Id);

    public Task<List<ToDoResponseDto>> GetAllUserId (int userId);

    }
}