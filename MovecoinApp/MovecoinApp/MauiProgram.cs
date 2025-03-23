using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MovecoinApp.Services;
using MovecoinApp.Views;
using MovecoinApp.ViewModels;

namespace MovecoinApp
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

            // Register services
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<ChallengeService>();
            builder.Services.AddSingleton<HealthMetricsService>();
            builder.Services.AddSingleton<MovecoinService>();

            // Register views and viewmodels
            builder.Services.AddTransient<DashboardPage>();
            builder.Services.AddTransient<DashboardViewModel>();
            builder.Services.AddTransient<ChallengeCreationPage>();
            builder.Services.AddTransient<ChallengeCreationViewModel>();
            builder.Services.AddTransient<ChallengeDetailsPage>();
            builder.Services.AddTransient<ChallengeDetailsViewModel>();
            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<ProfileViewModel>();

            builder.Services.AddLogging(logging =>
            {
                logging.AddDebug();
            });

            return builder.Build();
        }
    }
}