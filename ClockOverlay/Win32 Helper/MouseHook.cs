using System.Runtime.InteropServices;
using static ClockOverlay.Win32.NativeMethods;

namespace ClockOverlay.Win32;

public sealed class MouseHook : HookBase
{
    public MouseHook() : base(WH_MOUSE_LL)
    {
    }

    protected override void OnHook(int nCode, nint wParam, nint lParam)
    {
        if (wParam != WM_LBUTTONUP)
            return;

        var info = Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam);
        ClockForm.DoToggle(info.pt.x, info.pt.y);
    }
}