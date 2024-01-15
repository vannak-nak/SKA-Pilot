namespace Todo_API.Models;

public class AddTodoRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}