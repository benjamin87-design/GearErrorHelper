namespace GearErrorHelper.Views;

public partial class MaintenancePage : ContentPage
{
	public MaintenancePage(MaintenanceViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}