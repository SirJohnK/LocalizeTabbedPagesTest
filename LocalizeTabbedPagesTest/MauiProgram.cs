using Microsoft.Extensions.Logging;
using LocalizationResourceManager.Maui;
using LocalizeTabbedPagesTest.Resources;

namespace LocalizeTabbedPagesTest
{
    public static class MauiProgram
    {
        public static ILocalizationResourceManager? ResourceManager;

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseLocalizationResourceManager(settings =>
                {
                    settings.AddResource(AppResources.ResourceManager);
                    settings.RestoreLatestCulture(true);
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            var host = builder.Build();
            ResourceManager = host.Services.GetRequiredService<ILocalizationResourceManager>();
            return host;
        }
    }
}