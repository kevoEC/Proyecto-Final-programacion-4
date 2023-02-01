using ProyectoFinalProgramacion4.Models;
namespace ProyectoFinalProgramacion4.Views;

public partial class CategoriaListPage : ContentPage
{
    Categoria selectedCategoria;
    public CategoriaListPage()
	{
		InitializeComponent();
        //Categoria datosquemados1 = new Categoria("Computadoras de Escritorio", true);
        //Categoria datosquemados2 = new Categoria("Laptops", true);
        //Categoria datosquemados3 = new Categoria("Impresoras", true);
        listPageCategorias.ItemsSource = UpdateListCategoria();
    }

    async void OnItemAddedCategoria(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CategoriaItemPage));
    }

    private void ActualizarDatosCategoria(object sender, EventArgs e)
    {
        listPageCategorias.ItemsSource = App.proyectoREPO.ObtenerTodasLasCategorias();
    }

    private async void cambioCategoria(object sender, SelectionChangedEventArgs e)
    {
        selectedCategoria = e.CurrentSelection[0] as Categoria;
        await Navigation.PushAsync(new CategoriaItemPage
        {
            auxProyecto = selectedCategoria,
            BindingContext = selectedCategoria,
        });
    }

    private static List<Categoria> UpdateListCategoria()
    {
        List<Categoria> categoria = App.proyectoREPO.ObtenerTodasLasCategorias();
        return categoria;
    }
}