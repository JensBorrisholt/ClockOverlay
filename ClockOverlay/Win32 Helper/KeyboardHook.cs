using System.Runtime.InteropServices;
using static ClockOverlay.Win32.NativeMethods;

namespace ClockOverlay.Win32;

public sealed class KeyboardHook : HookBase
{
    public KeyboardHook() : base(WH_KEYBOARD_LL)
    {
    }

    protected override void OnHook(int nCode, nint wParam, nint lParam)
    {
        if (wParam != WM_KEYDOWN)
            return;
            
        var vkCode = Marshal.ReadInt32(lParam);
        if (vkCode == (int)Keys.Escape) 
            ClockForm.Instance?.Hide();
    }
}