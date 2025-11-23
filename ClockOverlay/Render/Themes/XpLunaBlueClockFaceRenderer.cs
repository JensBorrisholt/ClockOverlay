namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.XpLunaBlue)]
public sealed class XpLunaBlueClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(230, 225, 245, 255);
    protected override Color DialEdgeColor => Color.FromArgb(255, 72, 104, 172);
    protected override Color BezelColor => Color.FromArgb(255, 180, 200, 230);
    protected override Color InnerRingColor => Color.FromArgb(255, 110, 144, 202);
    protected override Color TickColor => Color.FromArgb(255, 40, 60, 110);
    protected override Color BigTickColor => Color.FromArgb(255, 34, 140, 34);
    protected override Color NumberColor => Color.FromArgb(255, 240, 245, 255);
}
