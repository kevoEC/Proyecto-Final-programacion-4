using ProyectoFinalProgramacion4.Data;
using ProyectoFinalProgramacion4.Services;

namespace ProyectoFinalProgramacion4;

public partial class App : Application
{
    public static SQLiteHelper proyectoREPO { get; private set; }
    public static FotoCall API { get; private set; }
    public App(SQLiteHelper repo, FotoCall api)
	{
		InitializeComponent();

		MainPage = new AppShell();
        proyectoREPO = repo;
        API = api;

    }

}
