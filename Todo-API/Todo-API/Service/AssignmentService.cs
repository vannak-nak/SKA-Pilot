namespace Todo_API.Service;
using Todo_API.Models;
public class AssignmentService
{
    private Connect _connect;

    public AssignmentService(Connect connect)
    {
        _connect = connect;
    }

    public IEnumerable<Assignment> Get()
    {
        string sql = "SELECT * FROM Assignment";
        return _connect.Query<Assignment>(sql);
    }

    public IEnumerable<Assignment> Add(AddTodoRequest request)
    {
        string sql = "INSERT INTO Assignment (Title, Description, Status, CreatedOn, CreatedBy, ModifiedOn, ModifiedBy) " +
                     "VALUES (@Title, @Description, @Status, '2024-01-10', 'Nak', '2024-01-10', 0)";
        return _connect.Query<Assignment>(sql, request);
    }

    public IEnumerable<Assignment> Update(UpdateTodoRequest request)
    {
        string sql = "UPDATE Assignment SET Status = @Status WHERE Id = @Id";
        return _connect.Query<Assignment>(sql, request);
    }
 
    public IEnumerable<Assignment> Delete(DeleteTodoRequest request)
    {
        string sql = "DELETE FROM Assignment WHERE Id = @Id";
        return _connect.Query<Assignment>(sql, request);
    }
}