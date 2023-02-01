using ProyectoFinalProgramacion4.Data;
using ProyectoFinalProgramacion4.Services;

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
        builder.Services.AddSingleton<FotoCall>(s => ActivatorUtilities.CreateInstance<FotoCall>(s));
        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IMap>(Map.Default);
        builder.Services.AddSingleton<SQLiteHelper>(s => ActivatorUtilities.CreateInstance<SQLiteHelper>(s, dbPath));
        return builder.Build();
	}
}
