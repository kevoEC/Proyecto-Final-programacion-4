using ProyectoFinalProgramacion4.Data;

namespace ProyectoFinalProgramacion4;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        string dbPath = FileAccessHelper.GetLocalFilePath("proyectoProgra4.db3");
        builder.Services.AddSingleton<SQLiteHelper>(s => ActivatorUtilities.CreateInstance<SQLiteHelper>(s, dbPath));
        return builder.Build();
	}
}
