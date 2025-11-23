namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.AeroBlue)]
public sealed class AeroBlueClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(190, 210, 235, 255);
    protected override Color DialEdgeColor => Color.FromArgb(230, 60, 110, 190);
    protected override Color BezelColor => Color.FromArgb(230, 210, 225, 240);
    protected override Color InnerRingColor => Color.FromArgb(210, 80, 135, 210);
    protected override Color TickColor => Color.FromArgb(220, 235, 245);
    protected override Color BigTickColor => Color.FromArgb(245, 250, 255);
    protected override Color NumberColor => Color.FromArgb(240, 245, 255);
}
