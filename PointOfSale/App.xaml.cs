namespace PointOfSale;

public partial class App : Application
{
    public App(ShellViewModel shellViewModel)
	{
		InitializeComponent();
        App.Current.UserAppTheme = AppTheme.Dark;
        MainPage = new AppShell(shellViewModel);
	}
}