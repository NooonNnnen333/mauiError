using MauiApp1;
using MauiApp333.Mehanism;
using Microsoft.Extensions.Logging;

namespace MauiApp333;

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
        
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<System111>();
        
        builder.Services.AddTransient<DitalPage>();
        builder.Services.AddTransient<NextPage>();
        
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}