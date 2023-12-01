using System.Diagnostics;

namespace MauiApp1.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Login failed", "Username or password is invalid", "Try again");
    }
}