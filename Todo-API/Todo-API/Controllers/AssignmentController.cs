using Microsoft.AspNetCore.Mvc;
using Todo_API.Service;
using Todo_API.Models;
namespace Todo_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AssignmentController : ControllerBase
{

    private AssignmentService _assignmentService;
    public AssignmentController(AssignmentService assignmentService)
    {
        _assignmentService = assignmentService;
    }

    [HttpPost("Get")]
    public ActionResult<List<Assignment>> Get()
    {
        return _assignmentService.Get().ToList();
    }
    
    [HttpPost("Add")]
    public ActionResult<List<Assignment>> Add(AddTodoRequest request)
    {
        return _assignmentService.Add(request).ToList();
    }
    
    [HttpPost("Update")]
    public ActionResult<List<Assignment>> Update(UpdateTodoRequest request)
    {
        return _assignmentService.Update(request).ToList();
    }
    
    [HttpPost("Delete")]
    public ActionResult<List<Assignment>> Delete(DeleteTodoRequest request)
    {
        return _assignmentService.Delete(request).ToList();
    }
}