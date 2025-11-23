namespace ClockOverlay.Render;

using System.Reflection;
using ClockOverlay.Render.Themes;

public enum ClockTheme
{
    Accent,
    AeroBlue,
    BrassAntique,
    CarbonFiber,
    Classic95,
    Dark,
    FireRed,
    GlassDark,
    GlassLight,
    Light,
    MinimalisticWhite,
    Neon,
    OceanBlue,
    RadialMetal,
    Retro,
    Sunburst,
    Win2000,
    Win311,
    WinME,
    XpLunaBlue,
    XpLunaOlive
}



public static class ClockThemeFactory
{
    private static readonly IReadOnlyDictionary<ClockTheme, Func<int, ClockFaceRendererBase>> _factory;

    static ClockThemeFactory()
    {
        _factory = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t =>
                t is { IsClass: true, IsAbstract: false } &&
                t.IsSubclassOf(typeof(ClockFaceRendererBase)))
            .Select(t => new
            {
                Type = t,
                Attr = t.GetCustomAttribute<ClockThemeAttribute>()
            })
            .Where(x => x.Attr is not null)
            .ToDictionary(
                x => x.Attr!.Theme,
                x => (Func<int, ClockFaceRendererBase>)(h =>
                    (ClockFaceRendererBase)Activator.CreateInstance(x.Type, h)!));
    }

    public static ClockFaceRendererBase Create(ClockTheme theme, int digitalLabelHeight = 60)
    {
        if (_factory.TryGetValue(theme, out var ctor))
            return ctor(digitalLabelHeight);

        return new DarkClockFaceRenderer(digitalLabelHeight);
    }

    public static IEnumerable<ClockTheme> AvailableThemes => _factory.Keys;
}
