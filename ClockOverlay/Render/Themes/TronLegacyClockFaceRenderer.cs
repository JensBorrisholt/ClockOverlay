
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.TronLegacy)]
public sealed class TronLegacyClockFaceRenderer : ClockFaceRendererBase
{
    public TronLegacyClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 5, 5, 10);
    protected override Color DialEdgeColor   => Color.FromArgb(255, 0, 180, 255);
    protected override Color BezelColor      => Color.FromArgb(255, 0, 140, 200);
    protected override Color InnerRingColor  => Color.FromArgb(255, 0, 220, 255);
    protected override Color TickColor       => Color.FromArgb(255, 0, 240, 255);
    protected override Color BigTickColor    => Color.FromArgb(255, 0, 180, 255);
    protected override Color NumberColor     => Color.FromArgb(255, 0, 255, 255);
}
