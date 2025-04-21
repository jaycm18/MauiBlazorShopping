using Microsoft.Extensions.Logging;
using MauiBlazorShopping.Services;

namespace MauiBlazorShopping
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
                });

            // Register HttpClient with base address
            builder.Services.AddHttpClient("ShoppingApi", client =>
            {
                client.BaseAddress = new Uri("https://shoppingbackendjcmo.azurewebsites.net/");
            });

            // Register ShoplistService
            builder.Services.AddSingleton<ShoplistService>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

