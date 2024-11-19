using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Services.Interfaces;

namespace TodoApp.Services;

public class TodoService:ITodoService
{
    public void Create(TodoDto dto)
    {
        dto.Id = Guid.NewGuid(); 
        dto.TaskDate = DateTime.Now; 
        Database.Todos.Add(dto); 
    }


    
    public void Update(TodoDto dto)
    {
        var existingTodo = Database.Todos.FirstOrDefault(todo => todo.Id == dto.Id);
        if (existingTodo != null)
        {
            existingTodo.Title = dto.Title;
            existingTodo.TitleDescription = dto.TitleDescription;
            existingTodo.TaskDate = dto.TaskDate; 
        }
        else
        {
            throw new InvalidOperationException("Todo not found.");
        }
    }

        
    public void Delete(Guid id)
    {
        var todo = Database.Todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            Database.Todos.Remove(todo); 
        }
        else
        {
            throw new InvalidOperationException("Todo not found.");
        }
    }
    
    
    
}