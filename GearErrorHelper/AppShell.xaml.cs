namespace GearErrorHelper;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
	}
}
