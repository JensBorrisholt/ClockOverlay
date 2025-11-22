namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Win32;

[ClockTheme(ClockTheme.Accent)]
public sealed class AccentClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    private static Color Accent => AccentColorHelper.GetAccentColor();

    protected override Color DialCenterColor => AccentColorHelper.Lighten(Accent, 0.6f);
    protected override Color DialEdgeColor => AccentColorHelper.Darken(Accent, 0.3f);
    protected override Color BezelColor => AccentColorHelper.Darken(Accent, 0.5f);
    protected override Color InnerRingColor => AccentColorHelper.Lighten(Accent, 0.3f);
    protected override Color TickColor => AccentColorHelper.Darken(Accent, 0.7f);
    protected override Color BigTickColor => AccentColorHelper.Lighten(Accent, 0.8f);
    protected override Color NumberColor => Color.White;
}
