using Microsoft.Extensions.Logging;
using SuperApp.Services;
using SuperApp.Views.Menu;
using Syncfusion.Maui.Core.Hosting;

namespace SuperApp
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
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.ConfigureSyncfusionCore();
            builder.Services.AddSingleton<Navigator>();

            builder.Services.AddTransient<DashboardPage>();
            builder.Services.AddTransient<TaskPage>();
            builder.Services.AddTransient<ReportPage>();
            builder.Services.AddTransient<CalendarPage>();
            builder.Services.AddTransient<ChatPage>();
            builder.Services.AddTransient<SettingsPage>();

            builder.Services.AddTransient<AnalyticsPage>();
            builder.Services.AddTransient<ClientPage>();
            builder.Services.AddTransient<NotePage>();
            builder.Services.AddTransient<HelpPage>();
            return builder.Build();
        }
    }
}
