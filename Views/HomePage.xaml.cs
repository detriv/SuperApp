using SuperApp.Models;
using SuperApp.Services;
using System.Collections.ObjectModel;
using MenuItem = SuperApp.Models.MenuItem;

namespace SuperApp.Views;

public partial class HomePage : ContentPage
{
    public ObservableCollection<BannerItem> Banners { get; set; }
    public ObservableCollection<MenuItem> Menus { get; set; }

    public HomePage()
    {
        InitializeComponent();

        Banners = new ObservableCollection<BannerItem>
            {
                new BannerItem { Title = "Diskon 20% paket premium", Subtitle = "Promo bulan ini", BackgroundColor = Color.FromArgb("#5B67F1") },
                new BannerItem { Title = "Fitur baru: Laporan otomatis", Subtitle = "Update terbaru", BackgroundColor = Color.FromArgb("#1D9E75") },
                new BannerItem { Title = "Undang tim, dapat bonus", Subtitle = "Referral program", BackgroundColor = Color.FromArgb("#D85A30") },
            };

        // Kodepoint di bawah sudah diverifikasi resmi dari font MaterialIcons-Regular.ttf
        Menus = new ObservableCollection<MenuItem>
            {
                new MenuItem { Title = "Dashboard", IconGlyph = "\ue871", IconColor = Color.FromArgb("#185FA5"), BackgroundColor = Color.FromArgb("#E6F1FB"), Route = "DashboardPage" },
                new MenuItem { Title = "Tugas",     IconGlyph = "\ue85d", IconColor = Color.FromArgb("#3B6D11"), BackgroundColor = Color.FromArgb("#EAF3DE"), Route = "TaskPage" },
                new MenuItem { Title = "Laporan",   IconGlyph = "\ue26b", IconColor = Color.FromArgb("#854F0B"), BackgroundColor = Color.FromArgb("#FAEEDA"), Route = "ReportPage" },
                new MenuItem { Title = "Kalender",  IconGlyph = "\ue935", IconColor = Color.FromArgb("#185FA5"), BackgroundColor = Color.FromArgb("#E6F1FB"), Route = "CalendarPage" },
                new MenuItem { Title = "Chat",      IconGlyph = "\ue0ca", IconColor = Color.FromArgb("#854F0B"), BackgroundColor = Color.FromArgb("#FAEEDA"), Route = "ChatPage" },
                new MenuItem { Title = "Pengaturan",IconGlyph = "\ue8b8", IconColor = Color.FromArgb("#A32D2D"), BackgroundColor = Color.FromArgb("#FCEBEB"), Route = "SettingsPage" },

                new MenuItem { Title = "Analitik",  IconGlyph = "\uf092", IconColor = Color.FromArgb("#185FA5"), BackgroundColor = Color.FromArgb("#E6F1FB"), Route = "AnalyticsPage" },
                new MenuItem { Title = "Klien",     IconGlyph = "\ue853", IconColor = Color.FromArgb("#854F0B"), BackgroundColor = Color.FromArgb("#FAEEDA"), Route = "ClientPage" },
                new MenuItem { Title = "Catatan",   IconGlyph = "\ue0ee", IconColor = Color.FromArgb("#A32D2D"), BackgroundColor = Color.FromArgb("#FCEBEB"), Route = "NotesPage" },
                new MenuItem { Title = "Bantuan",   IconGlyph = "\ue311", IconColor = Color.FromArgb("#854F0B"), BackgroundColor = Color.FromArgb("#FAEEDA"), Route = "HelpPage" },
                new MenuItem { Title = "Lainnya",   IconGlyph = "\ue5d3", IconColor = Color.FromArgb("#A32D2D"), BackgroundColor = Color.FromArgb("#FCEBEB"), Route = "MorePage" },
            };

        BindingContext = this;
    }

    private async void MenuItem_Tapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is MenuItem menu)
        {
            var navigator = Handler.MauiContext.Services.GetService<Navigator>();
            if (menu.Route != "MorePage")
            {
                await navigator.GoToAsync(menu.Route);
            }
        }
    }
}