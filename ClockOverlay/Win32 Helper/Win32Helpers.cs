namespace ClockOverlay.Win32;
using static NativeMethods;

public static class Win32Helpers
{
    public static nint GetCurrentModule() => GetModuleHandle(IntPtr.Zero);

    public static bool IsClickOnClock(int x, int y)
    {
        var hTaskbar = FindWindow("Shell_TrayWnd", null);
        if (hTaskbar == nint.Zero)
            return false;

        var hNotify = FindWindowEx(hTaskbar, nint.Zero, "TrayNotifyWnd", null);
        if (hNotify == nint.Zero)
            return false;

        if (!GetWindowRect(hNotify, out var notifyRect))
            return false;

        var clockRect = new RECT
        {
            Left = notifyRect.Right - 160,
            Right = notifyRect.Right,
            Top = notifyRect.Top,
            Bottom = notifyRect.Bottom
        };

        return x >= clockRect.Left &&
               x <= clockRect.Right &&
               y >= clockRect.Top &&
               y <= clockRect.Bottom;
    }
}
