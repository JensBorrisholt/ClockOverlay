
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.BladeRunner)]
public sealed class BladeRunnerClockFaceRenderer : ClockFaceRendererBase
{
    public BladeRunnerClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 18, 18, 30);
    protected override Color DialEdgeColor   => Color.FromArgb(255, 60, 0, 80);
    protected override Color BezelColor      => Color.FromArgb(255, 90, 0, 120);
    protected override Color InnerRingColor  => Color.FromArgb(255, 140, 0, 170);
    protected override Color TickColor       => Color.FromArgb(255, 255, 60, 230);
    protected override Color BigTickColor    => Color.FromArgb(255, 255, 0, 180);
    protected override Color NumberColor     => Color.FromArgb(255, 255, 180, 255);
}
