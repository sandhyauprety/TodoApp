using TodoApp.Models;

namespace TodoApp.Repositories.Interfaces;

public interface ITodoRepository
{
    List<TodoDto> GetAll(); 
    TodoDto GetbyId(Guid id); 
    void Delete(Guid id); 
}