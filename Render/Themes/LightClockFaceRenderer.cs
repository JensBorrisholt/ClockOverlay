namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.Light)]
public sealed class LightClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(245, 245, 245);
    protected override Color DialEdgeColor => Color.FromArgb(220, 220, 220);
    protected override Color BezelColor => Color.FromArgb(160, 160, 160);
    protected override Color InnerRingColor => Color.FromArgb(210, 210, 210);
    protected override Color TickColor => Color.FromArgb(80, 80, 80);
    protected override Color BigTickColor => Color.FromArgb(40, 40, 40);
    protected override Color NumberColor => Color.Black;
}
