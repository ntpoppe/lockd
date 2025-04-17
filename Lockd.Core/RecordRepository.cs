using Lockd.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Lockd.Core;

/// <summary>
/// Provides methods to access and manipulate Record entities in the database.
/// </summary>

public class RecordRepository
{
	private readonly DatabaseContext _dbContext; 

	public RecordRepository(DatabaseContext dbContext)
		=> _dbContext = dbContext;

	public async Task<List<Record>> GetAll(CancellationToken cancellationToken = default) 
	{
		if (_dbContext.Records is null)
			throw new InvalidOperationException("Records DbSet is not initialized.");

		return await _dbContext.Records.ToListAsync(cancellationToken);
	}

	public void Add() => throw new NotImplementedException();
	public void Delete() => throw new NotImplementedException();
	public void Update() => throw new NotImplementedException();
}

