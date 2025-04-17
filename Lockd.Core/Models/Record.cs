namespace Lockd.Core.Models;

/// <summary>
/// A database model representing a record saved in Lockd.
/// </summary>
public class Record 
{
	public int Id { get; set; }
	public required string Domain { get; set; }
	public required string PasswordHash { get; set; }
}
