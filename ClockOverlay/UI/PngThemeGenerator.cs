namespace ClockOverlay.UI;

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ClockOverlay.Render;
using ClockOverlay.Render.Themes;
using Microsoft.Extensions.Configuration;

public static class PngThemeGenerator
{
    public static void GenerateAllThemes(string outputDirectory)
    {
        Directory.CreateDirectory(outputDirectory);

        var configRoot = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
            .Build();

        var (manager, _) = new ThemeManager(configRoot!).CreateRenderer();


        var freezeTime = DateTime.Now;

        foreach (var theme in Enum.GetValues<ClockTheme>())
            GenerateForTheme(theme, manager, freezeTime, outputDirectory);
    }

    
    private static void GenerateForTheme(ClockTheme theme, ThemeManager themeManager, DateTime freezeTime,  string outputDirectory)
    {
        const int digitalLabelHeight = 60;
        var renderer = ClockThemeFactory.Create(theme, digitalLabelHeight);

        using var form = new ClockForm(themeManager, renderer)
        {
            StartPosition = FormStartPosition.Manual,
            Location = new Point(-2000, -2000),
            ShowInTaskbar = false
        };

        form.Show();
        Application.DoEvents();
        form.Refresh();

        
        Application.DoEvents();
        form.Refresh();
        //form._digitalLabel.Text = freezeTime.ToString("HH:mm:ss");

        var size = form.ClientSize;
        using var bitmap = new Bitmap(size.Width, size.Height);

        form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, size));

        var fileName = Path.Combine(outputDirectory, $"{theme}.png");
        bitmap.Save(fileName, ImageFormat.Png);
    }

    /// <summary>
    /// Venter til næste hele sekund (millisekund = 0).
    /// </summary>
    private static void WaitForNextSecond()
    {
        var now = DateTime.Now;
        int msToWait = 1000 - now.Millisecond;

        if (msToWait > 0)
            Thread.Sleep(msToWait);
    }
}
