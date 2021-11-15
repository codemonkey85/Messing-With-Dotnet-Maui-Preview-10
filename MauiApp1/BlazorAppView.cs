using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Controls;

namespace MauiApp1;

public class BlazorAppView : ContentView
{
    public BlazorAppView()
    {
        BlazorWebView blazorWebView = new() { HostPage = "wwwroot/index.html" };
        blazorWebView.RootComponents.Add(new RootComponent()
        {
            Selector = "#app",
            ComponentType = typeof(Main),
        });
        Content = blazorWebView;
    }
}
