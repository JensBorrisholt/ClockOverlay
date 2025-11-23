namespace ClockOverlay.Render.Themes;

using System.Drawing;

[ClockTheme(ClockTheme.Neon)]
public sealed class NeonClockFaceRenderer(int digitalLabelHeight = 60) : ClockFaceRendererBase(digitalLabelHeight)
{
    protected override Color DialCenterColor => Color.FromArgb(10, 10, 18);
    protected override Color DialEdgeColor => Color.FromArgb(30, 0, 50);
    protected override Color BezelColor => Color.FromArgb(0, 255, 200);    
    protected override Color InnerRingColor => Color.FromArgb(0, 180, 140);
    protected override Color TickColor => Color.FromArgb(255, 20, 147);  
    protected override Color BigTickColor => Color.FromArgb(255, 255, 0);
    protected override Color NumberColor => Color.FromArgb(0, 255, 200);
}
