namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.FireRed)]
public sealed class FireRedRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(30, 0, 0);
    protected override Color DialEdgeColor => Color.FromArgb(80, 0, 0);
    protected override Color BezelColor => Color.FromArgb(200, 50, 50);
    protected override Color InnerRingColor => Color.FromArgb(120, 20, 20);
    protected override Color TickColor => Color.FromArgb(255, 120, 60);
    protected override Color BigTickColor => Color.FromArgb(255, 180, 90);
    protected override Color NumberColor => Color.FromArgb(255, 200, 150);
}
