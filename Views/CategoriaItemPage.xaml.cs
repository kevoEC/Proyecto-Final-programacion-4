namespace ProyectoFinalProgramacion4.Views;
using ProyectoFinalProgramacion4.Models;
using System.Xml.Linq;

[QueryProperty(nameof(auxProyecto), "Aux")]
public partial class CategoriaItemPage : ContentPage
{   
    Categoria Item = new Categoria();
    Categoria Aux = new Categoria();
    bool _flag;
    public CategoriaItemPage()
	{
		InitializeComponent();
    }
    public Categoria auxProyecto
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
        App.proyectoREPO.AgregarCategoria(Item);
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
        App.proyectoREPO.RemoverCategoria(Item);
        await Shell.Current.GoToAsync("..");
    }
}