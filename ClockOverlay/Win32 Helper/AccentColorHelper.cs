namespace ClockOverlay.Win32;

using System.Drawing;
using System.Runtime.InteropServices;

public static class AccentColorHelper
{
    [DllImport("dwmapi.dll")]
    private static extern int DwmGetColorizationColor(out uint pcrColorization, out bool pfOpaqueBlend);

    public static Color GetAccentColor()
    {
        _ = DwmGetColorizationColor(out var rawColor, out _);

        var a = (byte)((rawColor >> 24) & 0xFF);
        var r = (byte)((rawColor >> 16) & 0xFF);
        var g = (byte)((rawColor >> 8) & 0xFF);
        var b = (byte)(rawColor & 0xFF);

        if (a == 0)
            a = 255;

        return Color.FromArgb(a, r, g, b);
    }

    public static Color Darken(Color c, float factor) =>
        Color.FromArgb(c.A, (int)(c.R * factor), (int)(c.G * factor), (int)(c.B * factor));
    public static Color Lighten(Color c, float factor) =>
        Color.FromArgb(c.A, c.R + (int)((255 - c.R) * factor), c.G + (int)((255 - c.G) * factor), c.B + (int)((255 - c.B) * factor));
}
