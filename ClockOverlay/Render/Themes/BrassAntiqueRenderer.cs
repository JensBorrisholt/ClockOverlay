namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.BrassAntique)]
public sealed class BrassAntiqueRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(225, 210, 170);
    protected override Color DialEdgeColor => Color.FromArgb(200, 170, 120);
    protected override Color BezelColor => Color.FromArgb(165, 130, 80);
    protected override Color InnerRingColor => Color.FromArgb(190, 160, 110);
    protected override Color TickColor => Color.FromArgb(90, 60, 35);
    protected override Color BigTickColor => Color.FromArgb(60, 40, 20);
    protected override Color NumberColor => Color.FromArgb(50, 30, 15);
}
