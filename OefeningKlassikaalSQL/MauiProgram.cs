using Microsoft.Extensions.Logging;
using OefeningKlassikaalSQL.Views;

namespace OefeningKlassikaalSQL;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<SalesPage>();
        builder.Services.AddSingleton<SalesPageViewModel>();

        return builder.Build();
	}
}
