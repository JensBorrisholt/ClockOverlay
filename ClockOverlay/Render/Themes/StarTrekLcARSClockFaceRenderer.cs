
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.StarTrekLcARS)]
public sealed class StarTrekLcARSClockFaceRenderer : ClockFaceRendererBase
{
    public StarTrekLcARSClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 10, 10, 20);
    protected override Color DialEdgeColor   => Color.FromArgb(255, 255, 170, 0);
    protected override Color BezelColor      => Color.FromArgb(255, 255, 110, 0);
    protected override Color InnerRingColor  => Color.FromArgb(255, 175, 110, 190);
    protected override Color TickColor       => Color.FromArgb(255, 255, 200, 0);
    protected override Color BigTickColor    => Color.FromArgb(255, 255, 100, 0);
    protected override Color NumberColor     => Color.FromArgb(255, 255, 190, 160);
}
