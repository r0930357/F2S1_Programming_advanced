namespace VakkenOefening;

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
                fonts.AddFont("TMCandor-SemiBold.otf", "TitelFont");
                fonts.AddFont("TMCandor-SemiBoldItalic.otf", "DetailFont");
            });

		return builder.Build();
	}
}
