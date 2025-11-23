namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.XpLunaOlive)]
public sealed class XpLunaOliveClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(230, 240, 245, 220);
    protected override Color DialEdgeColor => Color.FromArgb(255, 147, 160, 112);
    protected override Color BezelColor => Color.FromArgb(255, 180, 190, 150);
    protected override Color InnerRingColor => Color.FromArgb(255, 128, 140, 96);
    protected override Color TickColor => Color.FromArgb(255, 70, 80, 55);
    protected override Color BigTickColor => Color.FromArgb(255, 50, 60, 40);
    protected override Color NumberColor => Color.FromArgb(255, 45, 45, 35);
}
