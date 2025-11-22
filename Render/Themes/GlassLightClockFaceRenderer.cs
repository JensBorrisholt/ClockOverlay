namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.GlassLight)]
public sealed class GlassLightClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(180, 255, 255, 255);
    protected override Color DialEdgeColor => Color.FromArgb(220, 210, 225, 240);
    protected override Color BezelColor => Color.FromArgb(230, 220, 230);
    protected override Color InnerRingColor => Color.FromArgb(200, 190, 210, 235);
    protected override Color TickColor => Color.FromArgb(120, 130, 150);
    protected override Color BigTickColor => Color.FromArgb(70, 80, 100);
    protected override Color NumberColor => Color.FromArgb(40, 50, 70);
}
