using System.Runtime.InteropServices;

namespace ClockOverlay.Win32;

internal static partial class NativeMethods
{
    private const string USER_32 = "user32.dll";
    private const string KERNEL_32 = "kernel32.dll";

    internal const int WH_MOUSE_LL = 14;
    internal const int WH_KEYBOARD_LL = 13;
    internal const int WM_LBUTTONUP = 0x0202;
    internal const int WM_KEYDOWN = 0x0100;

    [StructLayout(LayoutKind.Sequential)]
    internal struct POINT
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public int mouseData;
        public int flags;
        public int time;
        public nint dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct RECT
    {
        public int Left, Top, Right, Bottom;
    }

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate nint HookProc(int nCode, nint wParam, nint lParam);

    [DllImport(KERNEL_32, EntryPoint = "GetModuleHandleW", SetLastError = true)]
    internal static extern nint GetModuleHandle(nint zero);

    [DllImport(USER_32, EntryPoint = "SetWindowsHookExW", SetLastError = true)]
    internal static extern nint SetWindowsHookEx(int idHook, HookProc lpfn, nint hMod, uint dwThreadId);

    [DllImport(USER_32, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool UnhookWindowsHookEx(nint hhk);

    [DllImport(USER_32)]
    internal static extern nint CallNextHookEx(nint hhk, int nCode, nint wParam, nint lParam);

    [DllImport(USER_32, EntryPoint = "FindWindowW", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern nint FindWindow(string? lpClassName, string? lpWindowName);

    [DllImport(USER_32, EntryPoint = "FindWindowExW", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern nint FindWindowEx(nint parentHandle, nint childAfter, string? className, string? windowTitle);

    [DllImport(USER_32)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool GetWindowRect(nint hwnd, out RECT lpRect);
}
