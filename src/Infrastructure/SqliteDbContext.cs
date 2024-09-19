using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Infrastructure;

public class SqliteDbContext : IdentityDbContext<IdentityUser>
{
  public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options) { }

  // public new DbSet<User> Users { get; set; }
}
