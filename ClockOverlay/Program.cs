using Microsoft.Extensions.Configuration;
using ClockOverlay.Win32;
using ClockOverlay.Render;

var configRoot = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var (manager, render) = new ThemeManager(configRoot!).CreateRenderer();
new ClockForm(manager, render).Hide();

using var tray = new TrayIconService();

if (tray.ShouldExitImmediately)
    return;

using var mouseHook = new MouseHook().Start();
using var keyboardHook = new KeyboardHook().Start();
Application.Run();