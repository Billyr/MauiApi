using MauiApi.Models;

namespace MauiApi.Pages;

public partial class ProductoPage : ContentPage
{
	public Categoria Categoria { get; set; }
	public ProductoModel lista { get; set; }

	public ProductoPage(Categoria categoria)
	{
        InitializeComponent();

        Categoria = categoria;
        
        ProductoModel lista = new ProductoModel();

        lista.Productos = new List<Producto>
        {
             new Producto { ProductoID = 1, Nombre="Papa Chica", CategoriaID = 1},
             new Producto { ProductoID = 2, Nombre="Papa Grande", CategoriaID = 1},
             new Producto { ProductoID = 1, Nombre="Coca Cola", CategoriaID = 2}
        };

        

        BindingContext = this;

        listarProductosByCategoria(categoria.CategoriaID);

    }

    private void listarProductosByCategoria(int categoriaId)
    {
        lista.Productos = lista.Productos.Where(p => p.CategoriaID == categoriaId).ToList();
    }

}