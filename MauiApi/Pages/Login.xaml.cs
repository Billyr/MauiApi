using MauiApi.Common;

namespace MauiApi.Pages;

public partial class Login : ContentPage
{
    public LoginModel loginModel { get; set; } = new();
    
    //public string usuario { get; set; }
    //public string pass { get; set; }


    public Login()
	{
		InitializeComponent();

        BindingContext = this;
	}

	private void OnRegistrar(object sender, EventArgs e)
	{
        loginModel.Username = "admin";
        loginModel.Password = "123";
		//DisplayAlert("Alerta", "Registrar button","Cancelar");
	}

    private void OnIngresar(object sender, EventArgs e)
    {
        if (loginModel.Username.Equals("admin") && loginModel.Password.Equals("123") )
            App.Current.MainPage = new CategoriaPage();
        else
            DisplayAlert("Error", "Credenciales incorrectas", "Cancelar");

    }


}