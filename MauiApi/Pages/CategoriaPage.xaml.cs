using MauiApi.Models;
using System.Runtime.InteropServices;

namespace MauiApi.Pages;

public partial class CategoriaPage : ContentPage
{

	private List<Categoria> listaFiltro = new List<Categoria>();
    public CategoriasModel lista { get; set; } = new();
	public string search { get; set; }

	public CategoriaPage()
	{
		InitializeComponent();

		lista.Categorias = new List<Categoria>
		{
			new Categoria { CategoriaID = 4, Nombre = "Papas", Imagen = "dotnet_bot", Descripcion = "Barcel"},
            new Categoria { CategoriaID = 3, Nombre = "Bebidas", Imagen = "dotnet_bot", Descripcion = "Embriagantes"},
            new Categoria { CategoriaID = 2, Nombre = "Golosinas", Imagen = "dotnet_bot", Descripcion = "Para disfrutar"},
            new Categoria { CategoriaID = 1, Nombre = "Plásticos", Imagen = "dotnet_bot", Descripcion = "Reyma"}
        };
		listaFiltro = lista.Categorias;
        BindingContext = this;
	}


	private void OnTextChanged(object sender, EventArgs e)
	{
        lista.Categorias = listaFiltro.Where(p => p.Nombre.ToLower().Contains(search.ToLower())).ToList();
    }

    private void lstCategorias_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var cat = e.Item as Categoria;
        
        App.Current.MainPage = new ProductoPage(cat);
    }

    private void lstCategorias_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //DisplayAlert("Categoria", $"{cat.CategoriaID}-{cat.Nombre}", "Cancel");
    }
}
