
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.DottedDark)]
public sealed class DottedDarkClockFaceRenderer : ClockFaceRendererBase
{
    public DottedDarkClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 20, 20, 20);
    protected override Color DialEdgeColor   => Color.FromArgb(255, 40, 40, 40);
    protected override Color BezelColor      => Color.FromArgb(255, 60, 60, 60);
    protected override Color InnerRingColor  => Color.FromArgb(255, 80, 80, 80);
    protected override Color TickColor       => Color.White;
    protected override Color BigTickColor    => Color.White;
    protected override Color NumberColor     => Color.LightGray;
}
