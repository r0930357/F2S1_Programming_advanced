using Microsoft.Extensions.Logging;

namespace OefeningOrders;

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

		builder.Services.AddSingleton<InstellingenPage>();
        builder.Services.AddSingleton<InstellingenViewModel>();

        builder.Services.AddSingleton<OrdersPage>();
        builder.Services.AddSingleton<OrdersPageViewModel>();

        builder.Services.AddSingleton<ProductenPage>();
        builder.Services.AddSingleton<ProductenPageViewModel>();

        builder.Services.AddSingleton<WerknemersPage>();
        builder.Services.AddSingleton<WerknemersPageViewModel>();
        return builder.Build();
	}
}
