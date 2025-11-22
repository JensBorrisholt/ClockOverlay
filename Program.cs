using Microsoft.Extensions.Configuration;
using ClockOverlay.Win32;
using ClockOverlay.Render;

//PngThemeGenerator.GenerateAllThemes(@"C:\GeneratedThemes");
var configRoot = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var (manager, render) = new ThemeManager(configRoot!).CreateRenderer();
new ClockForm(manager, render).Hide();

using var tray = new TrayIconService();

if (tray.ShouldExitImmediately)
    return;

var mouseHook = new MouseHook().Start();
var keyboardHook = new KeyboardHook().Start();
Application.Run();
