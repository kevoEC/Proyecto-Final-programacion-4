namespace ProyectoFinalProgramacion4.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void irMarca(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MarcaItemPage());
    }

    private async void irCategoria(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriaItemPage());
    }

    private async void irProducto(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductosItemPage());
    }

    private async void irTodasMarcas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MarcaListPage());
    }

    private async void irTodasCategorias(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriaListPage());
    }

    private async void irTodosProductos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductosListPage());
    }


}