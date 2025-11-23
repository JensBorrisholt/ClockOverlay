namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.Dark)]
public sealed class DarkClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(40, 40, 40);
    protected override Color DialEdgeColor => Color.FromArgb(10, 10, 10);
    protected override Color BezelColor => Color.FromArgb(200, 200, 200);
    protected override Color InnerRingColor => Color.FromArgb(80, 80, 80);
    protected override Color TickColor => Color.FromArgb(180, 180, 180);
    protected override Color BigTickColor => Color.FromArgb(230, 230, 230);
    protected override Color NumberColor => Color.White;
}
