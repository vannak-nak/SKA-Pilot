namespace Todo_API.Models;

public class UpdateTodoRequest
{
    public int Id { get; set; }
    public string status { get; set; }
}