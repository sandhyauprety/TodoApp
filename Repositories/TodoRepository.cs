using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Repositories.Interfaces;

namespace TodoApp.Repositories;

public class TodoRepository:ITodoRepository
{
    public List<TodoDto> GetAll()
    {
        return Database.Todos.ToList();
    }

    public TodoDto GetbyId(Guid id)
    {
        return Database.Todos.FirstOrDefault(t => t.Id == id);
    }

    public void Delete(Guid id)
    {
        var todo = Database.Todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            Database.Todos.Remove(todo);
        }
    }
}