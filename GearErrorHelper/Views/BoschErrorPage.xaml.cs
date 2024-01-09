namespace GearErrorHelper.Views;

public partial class BoschErrorPage : ContentPage
{
	public BoschErrorPage(BoschErrorViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
