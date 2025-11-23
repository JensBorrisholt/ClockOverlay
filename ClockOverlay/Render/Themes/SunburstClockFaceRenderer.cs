namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.Sunburst)]
public sealed class SunburstClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(255, 250, 220);  // næsten hvid gul
    protected override Color DialEdgeColor => Color.FromArgb(255, 180, 80);   // varm orange
    protected override Color BezelColor => Color.FromArgb(160, 90, 40);
    protected override Color InnerRingColor => Color.FromArgb(220, 150, 70);
    protected override Color TickColor => Color.FromArgb(90, 50, 20);
    protected override Color BigTickColor => Color.FromArgb(60, 35, 15);
    protected override Color NumberColor => Color.FromArgb(50, 30, 10);
}
