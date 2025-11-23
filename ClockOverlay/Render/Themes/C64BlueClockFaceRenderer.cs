
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.C64Blue)]
public sealed class C64BlueClockFaceRenderer : ClockFaceRendererBase
{
    public C64BlueClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 96, 96, 255);
    protected override Color DialEdgeColor   => Color.FromArgb(255, 80, 80, 200);
    protected override Color BezelColor      => Color.FromArgb(255, 50, 50, 150);
    protected override Color InnerRingColor  => Color.FromArgb(255, 120, 120, 255);
    protected override Color TickColor       => Color.White;
    protected override Color BigTickColor    => Color.White;
    protected override Color NumberColor     => Color.White;
}
