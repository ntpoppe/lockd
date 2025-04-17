using Microsoft.EntityFrameworkCore;
using Lockd.Core.Models;

namespace Lockd.Core;

/// <summary>
/// Represents the Entity Framework Core database context for the application.
/// Provides access to records stored in a database.
/// </summary>
public class DatabaseContext : DbContext
{
	public DbSet<Record>? Records { get; set; }

	public DatabaseContext(DbContextOptions<DatabaseContext> options)
		: base(options)
	{

	}
}
