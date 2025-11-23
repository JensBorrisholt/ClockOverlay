using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace ClockOverlay.Render;

public sealed class ThemeManager
{
    private readonly IConfigurationRoot _config;
    public ClockTheme CurrentTheme { get; private set; }
    public int DigitalLabelHeight { get; private set; } = 60;
    public bool SmoothAnimation { get; private set; }
    public bool ChimeEnabled { get; private set; }
    public ClockChimeMode ChimeMode { get; private set; }

    public event EventHandler? ThemeChanged;

    public ThemeManager(IConfigurationRoot configRoot)
    {
        _config = configRoot;
        Reload();
        ChangeToken.OnChange(() => _config.GetReloadToken(), OnConfigChanged);
    }

    private void OnConfigChanged()
    {
        Reload();
        ThemeChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Reload()
    {
        var themeName = _config["Clock:Theme"];
        if (!Enum.TryParse(themeName, ignoreCase: true, out ClockTheme theme))
            theme = ClockTheme.Dark;

        CurrentTheme = theme;

        if (int.TryParse(_config["Clock:DigitalLabelHeight"], out var h) && h > 0)
            DigitalLabelHeight = h;
        else
            DigitalLabelHeight = 60;

        SmoothAnimation = _config["Clock:SmoothAnimation"]?.Equals("true", StringComparison.OrdinalIgnoreCase) == true;
        ChimeEnabled = _config["Chime:Enabled"]?.Equals("true", StringComparison.OrdinalIgnoreCase) == true;

        var modeString = _config["Chime:Mode"] ?? "Off";
        if (!Enum.TryParse<ClockChimeMode>(modeString, ignoreCase: true, out var mode))
            mode = ClockChimeMode.Off;

        ChimeMode = mode;
    }

    public (ThemeManager manager, ClockFaceRendererBase render) CreateRenderer()
        => (this, ClockThemeFactory.Create(CurrentTheme, DigitalLabelHeight));
}
