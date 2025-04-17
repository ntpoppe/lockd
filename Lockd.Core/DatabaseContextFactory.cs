using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lockd.Core;

/// <summary>
/// Provides a design-time factory for creating DatabaseContext instances.
/// Solely used for EFC CLI tools for now.
/// </summary>
public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
{
	public DatabaseContext CreateDbContext(string[] args)
	{
		var dbPath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			"lockd.db");

		var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
		optionsBuilder.UseSqlite($"Data Source={dbPath}");

		return new DatabaseContext(optionsBuilder.Options);
	}
}

