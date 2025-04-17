using System.Diagnostics.CodeAnalysis;
using Lockd.Core.Models;

namespace Lockd.Desktop.ViewModels;

/// <summary>
/// Represents a Lockd.Core record as a view model.
/// </summary>
public class RecordViewModel
{
	[SetsRequiredMembers]
	public RecordViewModel(Record record)
	{
		Domain = record.Domain;
		PasswordHash = record.PasswordHash;
	}

	public required string Domain { get; set; }
	public required string PasswordHash { get; set; }
}

