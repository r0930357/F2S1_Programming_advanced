using Microsoft.Extensions.Logging;
using Voorbereidingsexamen.Views;

namespace Voorbereidingsexamen;

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

        builder.Services.AddSingleton<BoekenPage>();
        builder.Services.AddSingleton<BoekenAuteurPage>();
        builder.Services.AddSingleton<BoekenPageViewModel>();
        builder.Services.AddSingleton<WerknemersPage>();
        builder.Services.AddSingleton<WerknemersPageViewModel>();

        return builder.Build();
	}
}
