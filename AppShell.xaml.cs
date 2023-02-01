namespace ProyectoFinalProgramacion4;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.HomePage), typeof(Views.HomePage));
        Routing.RegisterRoute(nameof(Views.MarcaListPage), typeof(Views.MarcaListPage));
        Routing.RegisterRoute(nameof(Views.CategoriaListPage), typeof(Views.CategoriaListPage));
        Routing.RegisterRoute(nameof(Views.ProductosListPage), typeof(Views.ProductosListPage));
        Routing.RegisterRoute(nameof(Views.MarcaItemPage), typeof(Views.MarcaItemPage));
        Routing.RegisterRoute(nameof(Views.CategoriaItemPage), typeof(Views.CategoriaItemPage));
        Routing.RegisterRoute(nameof(Views.ProductosItemPage), typeof(Views.ProductosItemPage));
        
    }
}
