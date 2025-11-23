namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.Retro)]
public sealed class RetroClockFaceRenderer(int digitalLabelHeight = 60 ) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(240, 232, 210); // varm creme
    protected override Color DialEdgeColor => Color.FromArgb(210, 190, 150);
    protected override Color BezelColor => Color.FromArgb(120, 90, 60);   // brun metal
    protected override Color InnerRingColor => Color.FromArgb(190, 170, 130);
    protected override Color TickColor => Color.FromArgb(90, 70, 50);
    protected override Color BigTickColor => Color.FromArgb(60, 40, 30);
    protected override Color NumberColor => Color.FromArgb(50, 35, 25);
}
