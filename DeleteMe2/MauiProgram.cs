using DeleteMe2.Pages;
using Microsoft.Extensions.Logging;

namespace DeleteMe2
{

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
                    builder.Services.AddTransient<OnePage>();
                    builder.Services.AddTransient<TwoPage>();
                    builder.Services.AddTransient<ThreePage>();
                    builder.Services.AddTransient<FourPage>();
                    builder.Services.AddTransient<ViewModel1>();
                    builder.Services.AddTransient<ViewModel2>();
                    builder.Services.AddTransient<ViewModel3>();
                    builder.Services.AddTransient<ViewModel4>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
