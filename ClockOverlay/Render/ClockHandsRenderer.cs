using System.Drawing.Drawing2D;

namespace ClockOverlay.Render;

public static class ClockHandsRenderer
{
    public static void Draw(Graphics g, Point center, int radius, double hourAngle, double minAngle, double secAngle)
    {
        DrawHand(g, center, hourAngle, (int)(radius * 0.5), 4, Color.FromArgb(230, 230, 230));
        DrawHand(g, center, minAngle, (int)(radius * 0.7), 3, Color.FromArgb(200, 200, 200));
        DrawHand(g, center, secAngle, (int)(radius * 0.8), 2, Color.FromArgb(220, 60, 60));

        DrawCounterweight(g, center, secAngle, (int)(radius * 0.2));
        DrawCenterCap(g, center);
    }

    private static void DrawHand(Graphics g, Point c, double angle, int length, int width, Color color)
    {
        using var pen = new Pen(color, width)
        {
            StartCap = LineCap.Round,
            EndCap = LineCap.Round
        };

        var end = new Point(c.X + (int)(Math.Cos(angle) * length), c.Y + (int)(Math.Sin(angle) * length));
        g.DrawLine(pen, c, end);
    }

    private static void DrawCounterweight(Graphics g, Point c, double angle, int len)
    {
        using var pen = new Pen(Color.FromArgb(220, 60, 60), 2);
        var end = new Point(c.X - (int)(Math.Cos(angle) * len), c.Y - (int)(Math.Sin(angle) * len));
        g.DrawLine(pen, c, end);
    }

    private static void DrawCenterCap(Graphics g, Point c)
    {
        using var brush = new SolidBrush(Color.FromArgb(240, 240, 240));
        g.FillEllipse(brush, c.X - 4, c.Y - 4, 8, 8);

        using var pen = new Pen(Color.FromArgb(120, 120, 120), 1);
        g.DrawEllipse(pen, c.X - 6, c.Y - 6, 12, 12);
    }
}
