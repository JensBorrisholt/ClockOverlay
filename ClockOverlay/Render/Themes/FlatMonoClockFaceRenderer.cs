
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.FlatMono)]
public sealed class FlatMonoClockFaceRenderer : ClockFaceRendererBase
{
    public FlatMonoClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.White;
    protected override Color DialEdgeColor   => Color.White;
    protected override Color BezelColor      => Color.LightGray;
    protected override Color InnerRingColor  => Color.Gray;
    protected override Color TickColor       => Color.Black;
    protected override Color BigTickColor    => Color.Black;
    protected override Color NumberColor     => Color.Black;
}
