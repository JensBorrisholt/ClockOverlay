namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.RadialMetal)]
public sealed class RadialMetalClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(235, 235, 235);
    protected override Color DialEdgeColor => Color.FromArgb(170, 170, 170);
    protected override Color BezelColor => Color.FromArgb(130, 130, 130);
    protected override Color InnerRingColor => Color.FromArgb(200, 200, 200);
    protected override Color TickColor => Color.FromArgb(70, 70, 70);
    protected override Color BigTickColor => Color.FromArgb(40, 40, 40);
    protected override Color NumberColor => Color.FromArgb(30, 30, 30);
}
