namespace GearErrorHelper.Views;

public partial class InternalErrorPage : ContentPage
{
	public InternalErrorPage(InternalErrorViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
