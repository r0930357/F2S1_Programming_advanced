using CommunityToolkit.Maui;
using VakkenOefening.Views;

namespace VakkenOefening;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("TMCandor-SemiBold.otf", "TitelFont");
                fonts.AddFont("TMCandor-SemiBoldItalic.otf", "DetailFont");
            });
		
        // ViewModels
        builder.Services.AddSingleton<OverzichtVakkenViewModel>();
        builder.Services.AddSingleton<VakViewModel>();
        
        // Repos
		builder.Services.AddSingleton<VakRepository>();
        builder.Services.AddSingleton<DocentRepository>();
        
        // Views
        builder.Services.AddSingleton<OverzichtVakkenFlex>();
        builder.Services.AddSingleton<OverzichtVakkenGrid>();
        builder.Services.AddSingleton<OverzichtVakkenStack>();
        
        // Detailviews        
        builder.Services.AddSingleton<Vak1>();
        builder.Services.AddSingleton<Vak2>();
        builder.Services.AddSingleton<Vak3>();
        builder.Services.AddSingleton<Vak4>();
        builder.Services.AddSingleton<Vak5>();

        return builder.Build();
	}
}
