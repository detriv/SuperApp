using SuperApp.Views.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp.Helper;

public class RoutePage
{
    public static readonly Dictionary<string, Type> Routes = new()
    {
        { "DashboardPage", typeof(DashboardPage) },
        { "TaskPage", typeof(TaskPage) },
        { "ReportPage", typeof(ReportPage) },
        { "CalendarPage", typeof(CalendarPage) },
        { "ChatPage", typeof(ChatPage) },
        { "SettingsPage", typeof(SettingsPage) },

        { "AnalyticsPage", typeof(AnalyticsPage) },
        { "ClientPage", typeof(ClientPage) },
        { "NotesPage", typeof(NotePage) },
        { "HelpPage", typeof(HelpPage) },
    };
}
