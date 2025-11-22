namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.GlassDark)]
public sealed class GlassDarkClockFaceRenderer(int digitalLabelHeight = 60)    : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(170, 25, 30, 40);
    protected override Color DialEdgeColor => Color.FromArgb(220, 10, 15, 25);
    protected override Color BezelColor => Color.FromArgb(230, 200, 210, 225);
    protected override Color InnerRingColor => Color.FromArgb(200, 70, 90, 130);
    protected override Color TickColor => Color.FromArgb(210, 220, 235);
    protected override Color BigTickColor => Color.FromArgb(245, 250, 255);
    protected override Color NumberColor => Color.FromArgb(235, 240, 255);
}
