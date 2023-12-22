using OefeningPublishers.ViewModels;
using OefeningPublishers.Views;

namespace OefeningPublishers;

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

        builder.Services.AddSingleton<StorePage>();
        builder.Services.AddSingleton<StoreViewModel>();

        builder.Services.AddSingleton<EmployeePage>();
        builder.Services.AddSingleton<EmployeeViewModel>();

        return builder.Build();
	}
}
