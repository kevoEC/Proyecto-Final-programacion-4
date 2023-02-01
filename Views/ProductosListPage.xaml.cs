using ProyectoFinalProgramacion4.Models;

namespace ProyectoFinalProgramacion4.Views;

public partial class ProductosListPage : ContentPage
{
    Producto selectedProducto;
    public ProductosListPage()
	{
		InitializeComponent();
        listPageProductos.ItemsSource = UpdateListProducto();
    }

    async void OnItemAddedProducto(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ProductosItemPage));
    }

    private void ActualizarDatosProducto(object sender, EventArgs e)
    {
        listPageProductos.ItemsSource = App.proyectoREPO.ObtenerTodosLosProductos();
    }

    private async void cambioProducto(object sender, SelectionChangedEventArgs e)
    {
        selectedProducto = e.CurrentSelection[0] as Producto;
        await Navigation.PushAsync(new ProductosItemPage
        {
            auxProyecto = selectedProducto,
            BindingContext = selectedProducto,
        });
    }

    private static List<Producto> UpdateListProducto()
    {
        List<Producto> producto = App.proyectoREPO.ObtenerTodosLosProductos();
        return producto;
    }
}