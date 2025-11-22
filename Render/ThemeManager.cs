using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace ClockOverlay.Render;

public sealed class ThemeManager
{
    private readonly IConfigurationRoot _config;

    public ClockTheme CurrentTheme { get; private set; }
    public int DigitalLabelHeight { get; private set; } = 60;

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
    }

    public (ThemeManager manager, ClockFaceRendererBase render) CreateRenderer()
        => (this, ClockThemeFactory.Create(CurrentTheme, DigitalLabelHeight));
}
