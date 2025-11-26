namespace ClockOverlay.UI;

using System.Media;
using ClockOverlay.Render;
using static ClockOverlay.Win32.Win32Helpers;

public class ClockForm : Form
{
    private readonly Label _digitalLabel;
    private DateTime _lastFrameTime;
    private int _lastSecond = -1;

    private readonly ThemeManager _themeManager;
    private ClockFaceRendererBase _renderer;

    public static ClockForm Instance { get; private set; } = null!;

    public ClockFaceRendererBase Render
    {
        get => _renderer;
        set => SetRenderer(value);
    }

    private void HandleChime(DateTime now)
    {
        if (!_themeManager.ChimeEnabled)
            return;

        var shouldChime = false;

        switch (_themeManager.ChimeMode)
        {
            case ClockChimeMode.Hourly:
                shouldChime = now.Minute == 0 && now.Second == 0;
                break;

            case ClockChimeMode.QuarterHourly:
                shouldChime = (now.Minute % 15 == 0) && now.Second == 0;
                break;

            case ClockChimeMode.Off:
            default:
                return;
        }

        if (!shouldChime)
            return;

        SystemSounds.Asterisk.Play();
    }
    private void SetRenderer(ClockFaceRendererBase face)
    {
        if (IsDisposed)
            return;

        if (InvokeRequired)
        {
            BeginInvoke(new Action<ClockFaceRendererBase>(SetRenderer), face);
            return;
        }

        _renderer = face;
        _digitalLabel.Height = _renderer.DigitalLabelHeight;
        Invalidate();
    }

    public ClockForm(ThemeManager themeManager, ClockFaceRendererBase face)
    {
        Instance = this;
        _themeManager = themeManager;
        _renderer = face;
        FormBorderStyle = FormBorderStyle.None;
        ShowInTaskbar = false;
        TopMost = true;
        DoubleBuffered = true;

        Width = 350;
        Height = 260;

        BackColor = Color.Black;
        Opacity = 0.9;
        ForeColor = Color.White;

        _digitalLabel = new Label
        {
            Dock = DockStyle.Bottom,
            Height = _renderer.DigitalLabelHeight,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 28, FontStyle.Bold),
        };
        Controls.Add(_digitalLabel);

        _lastFrameTime = DateTime.Now;

        _themeManager.ThemeChanged += (_, _) =>
            Render = _themeManager.CreateRenderer().render;

        _ = RenderLoopAsync();
    }

    private async Task RenderLoopAsync()
    {
        const int targetFps = 60;
        const int delayMs = (int)ClockMath.MILLISECONDS_IN_SECOND / targetFps;

        while (!IsDisposed)
        {
            var now = DateTime.Now;
            _lastFrameTime = now;
            var doRender = now.Second != _lastSecond;
            if (doRender)
            {
                HandleChime(now);
                _lastSecond = now.Second;
            }

            if (Visible)
            {
                _digitalLabel.Text = now.ToString("HH:mm:ss");

                if (_themeManager.SmoothAnimation)
                    Invalidate();
                else if (doRender)
                    Invalidate();
            }

            await Task.Delay(delayMs);
        }
    }

    public static void DoToggle(int x, int y)
    {
        var clockForm = Instance!;
        if (IsClickOnClock(x, y) && !clockForm.Visible)
            clockForm.Show();
        else
            clockForm.Hide();
    }

    protected override void SetVisibleCore(bool value)
    {
        if (value && !IsHandleCreated)
        {
            StartPosition = FormStartPosition.Manual;

            var bounds = Screen.PrimaryScreen!.Bounds;
            Left = bounds.Right - Width - 10;
            Top = 10;
        }

        base.SetVisibleCore(value);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Render.DrawClockFace(e.Graphics, ClientSize, _lastFrameTime);
        base.OnPaint(e);
    }
}
