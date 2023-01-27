using System.ComponentModel.DataAnnotations;

namespace WebApplication.Features.Assignments.Views;

public class AssigmentRequest
{
    [Required]public string Subject { get; set; }
    
    [Required]public  string Description { get; set; }
    
    [Required]public DateTime DateLine { get; set; }
}