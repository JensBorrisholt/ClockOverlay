using System.ComponentModel;
using System.Runtime.InteropServices;
using static ClockOverlay.Win32.NativeMethods;
using static ClockOverlay.Win32.Win32Helpers;

namespace ClockOverlay.Win32;

public abstract class HookBase : IDisposable
{
    private readonly int _hookId;
    private readonly HookProc _proc;

    private nint _hookHandle;
    private bool _isStarted;

    protected HookBase(int hookId)
    {
        _hookId = hookId;
        _proc = HookCallbackInternal;
    }

    public HookBase Start()
    {
        if (_isStarted)
            return this;

        _hookHandle = SetWindowsHookEx(_hookId, _proc, GetCurrentModule(), 0);
        if (_hookHandle == nint.Zero)
            throw new Win32Exception(Marshal.GetLastWin32Error());

        _isStarted = true;
        return this;
    }

    public HookBase Stop()
    {
        if (!_isStarted)
            return this;

        if (_hookHandle != nint.Zero)
        {
            UnhookWindowsHookEx(_hookHandle);
            _hookHandle = nint.Zero;
        }

        _isStarted = false;
        return this;
    }

    protected abstract void OnHook(int nCode, nint wParam, nint lParam);

    private nint HookCallbackInternal(int nCode, nint wParam, nint lParam)
    {
        if (nCode >= 0)
            OnHook(nCode, wParam, lParam);

        return CallNextHookEx(_hookHandle, nCode, wParam, lParam);
    }

    public void Dispose()
    {
        Stop();
        GC.SuppressFinalize(this);
    }
}
