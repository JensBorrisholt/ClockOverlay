namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.WinME)]
public sealed class WinMeClockFaceRenderer(int digitalLabelHeight = 60)    : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(255, 235, 245, 235);
    protected override Color DialEdgeColor => Color.FromArgb(255, 190, 215, 210);
    protected override Color BezelColor => Color.FromArgb(255, 150, 180, 195);
    protected override Color InnerRingColor => Color.FromArgb(255, 120, 190, 160);
    protected override Color TickColor => Color.FromArgb(255, 40, 110, 100);
    protected override Color BigTickColor => Color.FromArgb(255, 20, 80, 70);
    protected override Color NumberColor => Color.FromArgb(255, 25, 35, 40);
}
