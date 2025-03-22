using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

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
            builder.Services.AddSingleton<Services.UserService>();
            builder.Services.AddSingleton<Services.ChallengeService>();
            builder.Services.AddSingleton<Services.MetricsService>();
            builder.Services.AddSingleton<Services.RewardService>();

            // Register ViewModels
            builder.Services.AddSingleton<ViewModels.DashboardViewModel>();
            builder.Services.AddSingleton<ViewModels.ProfileViewModel>();
            builder.Services.AddTransient<ViewModels.CreateChallengeViewModel>();
            builder.Services.AddTransient<ViewModels.ChallengeViewModel>();

            return builder.Build();
        }
    }
}