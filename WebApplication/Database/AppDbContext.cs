using Microsoft.EntityFrameworkCore;
using WebApplication.Features.Assignments.Models;

namespace WebApplication.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    
    public DbSet<AssignmentModel> Assignments { get; set; }
}