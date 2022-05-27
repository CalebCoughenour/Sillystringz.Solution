using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
  public class ProjectContext : DbContext
  {
    public DbSet<Project> Projects { get; set; }

    public ProjectContext(DbContextOptions options) : base(options) { }
  }
}