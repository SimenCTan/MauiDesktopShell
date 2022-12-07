namespace PointOfSale.Pages;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _loginViewModel;
    private readonly ShellViewModel _shellViewModel;
	public LoginPage(LoginViewModel loginViewModel,ShellViewModel shellViewModel)
	{
		InitializeComponent();
        _loginViewModel = loginViewModel;
        _shellViewModel = shellViewModel;
        BindingContext = _loginViewModel;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//home");
        _shellViewModel.IsFlyoutItemVisable = true;
    }
}