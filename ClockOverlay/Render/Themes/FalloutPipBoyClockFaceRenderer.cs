
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.FalloutPipBoy)]
public sealed class FalloutPipBoyClockFaceRenderer : ClockFaceRendererBase
{
    public FalloutPipBoyClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 0, 20, 0);
    protected override Color DialEdgeColor   => Color.FromArgb(255, 0, 60, 0);
    protected override Color BezelColor      => Color.FromArgb(255, 0, 90, 0);
    protected override Color InnerRingColor  => Color.FromArgb(255, 0, 130, 0);
    protected override Color TickColor       => Color.FromArgb(255, 0, 255, 0);
    protected override Color BigTickColor    => Color.FromArgb(255, 140, 255, 140);
    protected override Color NumberColor     => Color.FromArgb(255, 140, 255, 140);
}
