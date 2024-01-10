using GearErrorHelper.Models;
using GearErrorHelper.Resources.Strings;

namespace GearErrorHelper.ViewModels;

public partial class InternalErrorViewModel : BaseViewModel
{
	[ObservableProperty]
	private string errorSearch;
	[ObservableProperty]
	private string errorType;
	[ObservableProperty]
	private string value;
	[ObservableProperty]
	private string display;

	//Error Properties
	[ObservableProperty]
	private string errorNumber;
	[ObservableProperty]
	private string errorTitle;
	[ObservableProperty]
	private string errorText;
	[ObservableProperty]
	private string errorDescription;
	[ObservableProperty]
	private string errorHandling;

	//Lists
	[ObservableProperty]
	private ObservableCollection<InternalErrorModel> errorTypes;

	//Selected
	private InternalErrorModel selectedErrorType;
	public InternalErrorModel SelectedErrorType
	{
		get {return selectedErrorType; }
		set{selectedErrorType = value;}
	}
	public InternalErrorViewModel()
	{
		ErrorTypes = new ObservableCollection<InternalErrorModel>();

		//Add the error types to the list
		ErrorTypes.Add(new InternalErrorModel { Key = 1, Value = "E", Display = "Error"});
		ErrorTypes.Add(new InternalErrorModel { Key = 2, Value = "W", Display = "Warning" });
		ErrorTypes.Add(new InternalErrorModel { Key = 3, Value = "I", Display = "Information" });
		ErrorTypes.Add(new InternalErrorModel { Key = 3, Value = "F", Display = "Fatal" });
	}

	[RelayCommand]
	public async Task ErrorSearchChanged()
	{
		//get the error description as a string from appresources.resx
		var errorNumber = AppResources.ResourceManager.GetString(SelectedErrorType.Value + ErrorSearch);
		if (errorNumber == null)
		{
			//if the error number is not found in the resource file, then show message to user
			await Shell.Current.DisplayAlert("Error", "The error" + " " + SelectedErrorType.Value + ErrorSearch + " " + " is not in the database.", "OK");
		}
		else
		{
			ErrorTitle = AppResources.ResourceManager.GetString(SelectedErrorType.Value + ErrorSearch + "Title")?.ToString() ?? "";
			ErrorText = AppResources.ResourceManager.GetString(SelectedErrorType.Value + ErrorSearch + "Text")?.ToString() ?? "";
			ErrorDescription = AppResources.ResourceManager.GetString(SelectedErrorType.Value + ErrorSearch + "Description")?.ToString() ?? "";
			ErrorHandling = AppResources.ResourceManager.GetString(SelectedErrorType.Value + ErrorSearch + "Handling")?.ToString() ?? "";
		}
	}
}
