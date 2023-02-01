using ProyectoFinalProgramacion4.Models;
using System.Runtime.Intrinsics.X86;

namespace ProyectoFinalProgramacion4.Views;

[QueryProperty(nameof(auxProyecto), "Aux")]
public partial class ProductosItemPage : ContentPage
{
    Producto Item = new Producto();
    Producto Aux = new Producto();
    bool _flag;
    string img;
    public ProductosItemPage()
	{
		InitializeComponent();
	}

    public Producto auxProyecto
    {
        get => Aux;
        set
        {
            Aux = value;
        }
    }

    private async void mostrarBuscadorDeArchivos(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            FileTypes = FilePickerFileType.Images,
        });

        if (result == null)
        {
            return;
        }

        var stream = result.FullPath;
        img = stream.ToString();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        Item = Aux;
        Item.Nombre = nombre.Text;
        Item.Descripcion = descripcion.Text;
        Item.Precio = Convert.ToInt32(precio.Text);
        Item.Stock = Convert.ToInt32(stock.Text);
        Item.RutaImagen = img;
        Item.Activo = _flag;

        if (string.IsNullOrEmpty(Item.Descripcion))
        {
            return;
        }
        App.proyectoREPO.AgregarProducto(Item);
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
        App.proyectoREPO.RemoverProducto(Item);
        await Shell.Current.GoToAsync("..");
    }
}