using SuperApp.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp.Services;

public class Navigator
{
    private readonly IServiceProvider _provider;

    public Navigator(IServiceProvider provider)
    {
        _provider = provider;
    }

    public async Task GoToAsync(string route)
    {
        if (!RoutePage.Routes.TryGetValue(route, out var pageType))
            throw new Exception($"Route '{route}' tidak ditemukan");

        var page = _provider.GetService(pageType) as Page;

        if (page == null)
            throw new Exception($"Page '{route}' belum terdaftar di DI");

        await Application.Current.MainPage.Navigation.PushAsync(page);
    }
}
