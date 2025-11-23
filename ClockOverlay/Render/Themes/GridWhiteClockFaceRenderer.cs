
using System.Drawing;
using ClockOverlay.Render;

[ClockTheme(ClockTheme.GridWhite)]
public sealed class GridWhiteClockFaceRenderer : ClockFaceRendererBase
{
    public GridWhiteClockFaceRenderer(int h = 60) : base(h) {}

    protected override Color DialCenterColor => Color.FromArgb(255, 245, 245, 245);
    protected override Color DialEdgeColor   => Color.LightGray;
    protected override Color BezelColor      => Color.Silver;
    protected override Color InnerRingColor  => Color.Gainsboro;
    protected override Color TickColor       => Color.DarkGray;
    protected override Color BigTickColor    => Color.Black;
    protected override Color NumberColor     => Color.Black;
}
