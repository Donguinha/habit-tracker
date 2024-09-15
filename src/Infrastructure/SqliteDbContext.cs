using Microsoft.EntityFrameworkCore;

namespace HabitTracker.src.Infrastructure;

public class SqliteDbContext : DbContext
{
  public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options) { }


}
