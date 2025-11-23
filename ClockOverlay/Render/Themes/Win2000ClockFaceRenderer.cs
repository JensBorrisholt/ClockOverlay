namespace ClockOverlay.Render.Themes;

using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.Win2000)]
public sealed class Win2000ClockFaceRenderer(int digitalLabelHeight = 60)    : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(255, 220, 220, 228);
    protected override Color DialEdgeColor => Color.FromArgb(255, 184, 180, 192);
    protected override Color BezelColor => Color.FromArgb(255, 132, 130, 144);
    protected override Color InnerRingColor => Color.FromArgb(255, 160, 168, 192);
    protected override Color TickColor => Color.FromArgb(255, 40, 60, 110);
    protected override Color BigTickColor => Color.FromArgb(255, 20, 40, 80);
    protected override Color NumberColor => Color.FromArgb(255, 15, 15, 25);
}
