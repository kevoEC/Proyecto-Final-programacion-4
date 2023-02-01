using ProyectoFinalProgramacion4.Models;
namespace ProyectoFinalProgramacion4.Views;

public partial class MarcaListPage : ContentPage
{
    Marca selectedMarca;
    public MarcaListPage()
	{
		InitializeComponent();
        //Marca datosquemados1 = new Marca("Presupuesto bajo", true);
        //Marca datosquemados2 = new Marca("HP", true);
        //Marca datosquemados3 = new Marca("Kingstom", true);
        listPageMarca.ItemsSource = UpdateListMarca();
    }

    /*CREACION LIST MARCA*/
    async void OnItemAddedMarca(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MarcaItemPage));
    }

    private void ActualizarDatosMarca(object sender, EventArgs e)
    {
        listPageMarca.ItemsSource = App.proyectoREPO.ObtenerTodasLasMarcas();
    }

    private async void cambioMarca(object sender, SelectionChangedEventArgs e)
    {
        selectedMarca = e.CurrentSelection[0] as Marca;
        await Navigation.PushAsync(new MarcaItemPage
        {
            auxProyecto = selectedMarca,
            BindingContext = selectedMarca,
        });
    }

    private static List<Marca> UpdateListMarca()
    {
        List<Marca> marca = App.proyectoREPO.ObtenerTodasLasMarcas();
        return marca;
    }
}