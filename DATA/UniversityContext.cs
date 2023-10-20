using Microsoft.EntityFrameworkCore;


public class UniversityContext : DbContext
{
  public DbSet1<Course> Course { get; set; } = null!;
  public DbSet2<Enrollment> Enrollment { get; set; } = null!;
  public DbSet3<Student> Student { get; set; } = null!;
  public string DbPath { get; private set; }


  public UniversityContext()
  {
    // Path to SQLite database file
    DbPath = "EFUniversity.db";
  }


  // The following configures EF to create a SQLite database file locally
  protected override void OnConfiguring(DbContextOptionsBuilder options)
  {
    // Use SQLite as database
    options.UseSqlite($"Data Source={DbPath}");
    // Optional: log SQL queries to console
    //options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
  }
}
