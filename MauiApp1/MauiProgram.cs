using CommunityToolkit.Maui;
using LiveChartsCore.SkiaSharpView.Maui;
using MauiApp1.ViewModels;
using MauiApp1.Views;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseSkiaSharp()
            .UseLiveCharts()
            .AddPages()
            .UseMauiCommunityToolkit()
            .AddViewModels()
            .ConfigureFonts(fonts =>
            {
                // OpenSans
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                
                // Inter Regular Variants
                fonts.AddFont("Inter_18pt-Regular.ttf", "InterRegular");
                fonts.AddFont("Inter_24pt-Regular.ttf", "InterRegular24");
                fonts.AddFont("Inter_28pt-Regular.ttf", "InterRegular28");
                
                // Inter Bold Variants
                fonts.AddFont("Inter_18pt-Bold.ttf", "InterBold");
                fonts.AddFont("Inter_24pt-Bold.ttf", "InterBold24");
                fonts.AddFont("Inter_28pt-Bold.ttf", "InterBold28");
                
                // Inter Medium Variants
                fonts.AddFont("Inter_18pt-Medium.ttf", "InterMedium");
                fonts.AddFont("Inter_24pt-Medium.ttf", "InterMedium24");
                fonts.AddFont("Inter_28pt-Medium.ttf", "InterMedium28");
                
                // Inter SemiBold Variants
                fonts.AddFont("Inter_18pt-SemiBold.ttf", "InterSemiBold");
                fonts.AddFont("Inter_24pt-SemiBold.ttf", "InterSemiBold24");
                fonts.AddFont("Inter_28pt-SemiBold.ttf", "InterSemiBold28");
                
                // Inter Light Variants
                fonts.AddFont("Inter_18pt-Light.ttf", "InterLight");
                fonts.AddFont("Inter_24pt-Light.ttf", "InterLight24");
                fonts.AddFont("Inter_28pt-Light.ttf", "InterLight28");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    private static MauiAppBuilder AddPages(this MauiAppBuilder builder)
    {
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        Routing.RegisterRoute("DashboardPage", typeof(DashboardPage));

        return builder;
    }

    private static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<DashboardViewModel>();
        return builder;
    }
}