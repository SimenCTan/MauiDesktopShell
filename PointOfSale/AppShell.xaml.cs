using PointOfSale.Pages;

namespace PointOfSale;

public partial class AppShell : Shell
{
    private readonly ShellViewModel _shellViewModel;
	public AppShell(ShellViewModel shellViewModel)
	{
		InitializeComponent();
        _shellViewModel = shellViewModel;
        BindingContext = _shellViewModel;
        InitRoutes();
	}

    private void InitRoutes()
    {
        Routing.RegisterRoute(nameof(AddProductView), typeof(AddProductView));
    }

    private string selectedRoute;
    public string SelectedRoute
    {
        get { return selectedRoute; }
        set
        {
            selectedRoute = value;
            OnPropertyChanged();
        }
    }

    async void OnMenuItemChanged(System.Object sender, CheckedChangedEventArgs e)
    {
        if(!String.IsNullOrEmpty(selectedRoute))
            await Shell.Current.GoToAsync($"//{selectedRoute}");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        _shellViewModel.IsFlyoutItemVisable = false;
        await Shell.Current.GoToAsync($"//login");
    }
}