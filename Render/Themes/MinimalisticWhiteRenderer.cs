namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.MinimalisticWhite)]
public sealed class MinimalisticWhiteRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(255, 255, 255);
    protected override Color DialEdgeColor => Color.FromArgb(240, 240, 240);
    protected override Color BezelColor => Color.FromArgb(200, 200, 200);
    protected override Color InnerRingColor => Color.FromArgb(235, 235, 235);
    protected override Color TickColor => Color.FromArgb(120, 120, 120);
    protected override Color BigTickColor => Color.FromArgb(60, 60, 60);
    protected override Color NumberColor => Color.FromArgb(40, 40, 40);
}
