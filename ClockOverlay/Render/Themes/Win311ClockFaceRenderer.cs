namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.Win311)]
public sealed class Win311ClockFaceRenderer(int digitalLabelHeight = 60)    : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(255, 192, 192, 192);
    protected override Color DialEdgeColor => Color.FromArgb(255, 160, 160, 160);
    protected override Color BezelColor => Color.FromArgb(255, 128, 128, 128);
    protected override Color InnerRingColor => Color.FromArgb(255, 208, 208, 208);
    protected override Color TickColor => Color.FromArgb(255, 0, 0, 128);
    protected override Color BigTickColor => Color.FromArgb(255, 0, 0, 0);
    protected override Color NumberColor => Color.Black;
}
