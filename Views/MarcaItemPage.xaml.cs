namespace ProyectoFinalProgramacion4.Views;
using ProyectoFinalProgramacion4.Models;
using System.Xml.Linq;

[QueryProperty(nameof(auxProyecto), "Aux")]
public partial class MarcaItemPage : ContentPage
{

    Marca Item = new Marca();
    Marca Aux = new Marca();
    bool _flag;
    public MarcaItemPage()
	{
		InitializeComponent();
        
    }
    public Marca auxProyecto
    {
        get => Aux;
        set
        {
            Aux = value;
        }
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        Item = Aux;
        Item.Descripcion = descripcion.Text;
        Item.Activo = _flag;

        if (string.IsNullOrEmpty(Item.Descripcion))
        {
            return;
        }
        App.proyectoREPO.AgregarMarca(Item);
        await Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    async void DeletedClicked(object sender, EventArgs e)
    {
        Item = Aux;
        App.proyectoREPO.RemoverMarca(Item);
        await Shell.Current.GoToAsync("..");
    }
}