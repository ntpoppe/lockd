using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Lockd.Core;

namespace Lockd.Desktop.ViewModels;

public class MainViewModel 
{
	private readonly RecordRepository _repo;

#region Constructors
	
	public MainViewModel(RecordRepository repo) 
	{
		_repo = repo;
	}

#endregion

#region Properties

	public required ObservableCollection<RecordViewModel> Records { get; set; } = new();

#endregion

#region Methods

	public async Task InitializeAsync()
	{
		var coreRecords = await _repo.GetAll();
		foreach (var record in coreRecords)
		{
			Records.Add(new RecordViewModel(record));
		}
	}

#endregion
}
