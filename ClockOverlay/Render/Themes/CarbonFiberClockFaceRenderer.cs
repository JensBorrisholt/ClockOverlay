namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.CarbonFiber)]
public sealed class CarbonFiberClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(25, 25, 30);
    protected override Color DialEdgeColor => Color.FromArgb(10, 10, 15);
    protected override Color BezelColor => Color.FromArgb(90, 90, 100);
    protected override Color InnerRingColor => Color.FromArgb(50, 50, 60);
    protected override Color TickColor => Color.FromArgb(180, 180, 190);
    protected override Color BigTickColor => Color.FromArgb(230, 230, 240);
    protected override Color NumberColor => Color.FromArgb(210, 210, 220);
}
