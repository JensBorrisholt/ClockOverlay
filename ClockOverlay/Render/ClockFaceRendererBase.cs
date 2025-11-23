namespace ClockOverlay.Render;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public abstract class ClockFaceRendererBase(int digitalLabelHeight)
{
    private Bitmap? _bitmap;
    private Size _lastSize = Size.Empty;
    public int DigitalLabelHeight { get; } = digitalLabelHeight;

    public void DrawClockFace(Graphics g, Size clientSize, DateTime now)
    {
        var _secAngle = ClockMath.SecondsAngle(now);
        var _minAngle = ClockMath.MinutesAngle(now);
        var _hourAngle = ClockMath.HoursAngle(now);
        DrawClockFace(g, clientSize, _hourAngle, _minAngle, _secAngle);
    }

    public void DrawClockFace(Graphics g, Size clientSize, double hourAngle, double minAngle, double secAngle)
    {
        var analogSize = new Size(clientSize.Width, clientSize.Height - DigitalLabelHeight);
        if (analogSize.Width <= 0 || analogSize.Height <= 0)
            return;

        BuildBitmap(analogSize);

        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.DrawImageUnscaled(_bitmap!, 0, 0);

        var center = new Point(analogSize.Width / 2, analogSize.Height / 2);
        var radius = Math.Min(analogSize.Width, analogSize.Height) / 2 - 10;

        ClockHandsRenderer.Draw(g, center, radius, hourAngle, minAngle, secAngle);
    }

    private void BuildBitmap(Size size)
    {
        if (_bitmap != null && size == _lastSize)
            return;

        _bitmap?.Dispose();
        _bitmap = new Bitmap(size.Width, size.Height);
        _lastSize = size;

        using var g = Graphics.FromImage(_bitmap);
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var center = new Point(size.Width / 2, size.Height / 2);
        int radius = Math.Min(size.Width, size.Height) / 2 - 10;

        DrawBackground(g, center, radius);
        DrawTicks(g, center, radius);
        DrawNumbers(g, center, radius);
    }

    private void DrawBackground(Graphics g, Point center, int radius)
    {
        var rect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);

        using (var path = new GraphicsPath())
        {
            path.AddEllipse(rect);
            using var brush = new PathGradientBrush(path)
            {
                CenterColor = DialCenterColor,
                SurroundColors = [DialEdgeColor]
            };
            g.FillEllipse(brush, rect);
        }

        using var bezel = new Pen(BezelColor, 3);
        g.DrawEllipse(bezel, rect);

        var inner = radius - 10;
        var innerRect = new Rectangle(center.X - inner, center.Y - inner, inner * 2, inner * 2);
        using var innerPen = new Pen(InnerRingColor, 1.5f);
        g.DrawEllipse(innerPen, innerRect);
    }

    private void DrawTicks(Graphics g, Point center, int radius)
    {
        using var tickPen = new Pen(TickColor, 1.5f);
        using var bigPen = new Pen(BigTickColor, 2.5f);

        for (var i = 0; i < 60; i++)
        {
            var angle = ClockMath.TwoPi * (i / 60.0) - ClockMath.HalfPi;
            var outer = radius - 4;
            var inner = i % 5 == 0 ? outer - 12 : outer - 6;

            var p1 = new Point(center.X + (int)(Math.Cos(angle) * outer), center.Y + (int)(Math.Sin(angle) * outer));
            var p2 = new Point(center.X + (int)(Math.Cos(angle) * inner), center.Y + (int)(Math.Sin(angle) * inner));

            g.DrawLine(i % 5 == 0 ? bigPen : tickPen, p1, p2);
        }
    }

    private void DrawNumbers(Graphics g, Point center, int radius)
    {
        DrawNumber(g, "12", center, radius - 28, 0);
        DrawNumber(g, "3", center, radius - 28, 90);
        DrawNumber(g, "6", center, radius - 28, 180);
        DrawNumber(g, "9", center, radius - 28, 270);
    }

    private void DrawNumber(Graphics g, string text, Point center, int r, double deg)
    {
        var a = deg * Math.PI / 180 - Math.PI / 2;
        var pos = new Point(center.X + (int)(Math.Cos(a) * r), center.Y + (int)(Math.Sin(a) * r));

        using var font = new Font("Segoe UI", 10, FontStyle.Bold);
        var size = TextRenderer.MeasureText(text, font);
        var rect = new Rectangle(pos.X - size.Width / 2, pos.Y - size.Height / 2, size.Width, size.Height);
        TextRenderer.DrawText(g, text, font, rect, NumberColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    // Tema-afhængige farver
    protected abstract Color DialCenterColor { get; }
    protected abstract Color DialEdgeColor { get; }
    protected abstract Color BezelColor { get; }
    protected abstract Color InnerRingColor { get; }
    protected abstract Color TickColor { get; }
    protected abstract Color BigTickColor { get; }
    protected abstract Color NumberColor { get; }
}
