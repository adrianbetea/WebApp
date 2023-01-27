using WebApplication.Base.Models;

namespace WebApplication.Features.Assignments.Models;

public class AssignmentModel : Model
{
    public string Subject { get; set; }
    
    public string Description { get; set; }
    
    public DateTime DateLine { get; set; }
}