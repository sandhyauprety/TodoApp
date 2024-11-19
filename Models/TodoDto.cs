namespace TodoApp.Models;

public class TodoDto
{
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public string Title { get; set; }
    public string  TitleDescription{ get; set; }
    public DateTime TaskDate { get; set; }

}