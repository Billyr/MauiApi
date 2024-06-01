using MauiApi.Pages;

namespace MauiApi;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Login();
	}
}
