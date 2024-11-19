using TodoApp.Models;

namespace TodoApp.Data;

public static class Database
{
    public static List<TodoDto> Todos { get; } = new List<TodoDto>();

}