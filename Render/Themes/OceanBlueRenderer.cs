namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.OceanBlue)]
public sealed class OceanBlueRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(200, 220, 235);
    protected override Color DialEdgeColor => Color.FromArgb(160, 185, 210);
    protected override Color BezelColor => Color.FromArgb(70, 110, 150);
    protected override Color InnerRingColor => Color.FromArgb(130, 165, 195);
    protected override Color TickColor => Color.FromArgb(50, 85, 120);
    protected override Color BigTickColor => Color.FromArgb(30, 60, 95);
    protected override Color NumberColor => Color.FromArgb(20, 45, 75);
}
