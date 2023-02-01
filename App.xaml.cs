using ProyectoFinalProgramacion4.Data;
namespace ProyectoFinalProgramacion4;

public partial class App : Application
{
    public static SQLiteHelper proyectoREPO { get; private set; }
    public App(SQLiteHelper repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
        proyectoREPO = repo;

    }

}
