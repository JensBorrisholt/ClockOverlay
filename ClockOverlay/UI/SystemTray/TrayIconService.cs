using Microsoft.Win32;
namespace ClockOverlay.UI.SystemTray;

public class TrayIconService : IDisposable
{
    private readonly NotifyIcon _icon;
    private const string RUN_KEY = @"Software\Microsoft\Windows\CurrentVersion\Run";
    private const string APP_NAME = "StortUrApp";

    public bool ShouldExitImmediately { get; }

    public TrayIconService()
    {

        _icon = new NotifyIcon
        {
            Icon = SystemIcons.Application,
            Visible = true,
            Text = "Stort ur"
        };

        ShouldExitImmediately = HandleCommandLine();
        if (ShouldExitImmediately)
            return;

        BuildMenu();
    }

    private void BuildMenu()
    {
        var menu = new ContextMenuStrip();
        menu.Items.Add("Luk", null, (_, _) =>
        {
            _icon.Visible = false;
            Application.Exit();
        });

        _icon.ContextMenuStrip = menu;
    }

    public static void Install()
    {
        using var key = Registry.CurrentUser.OpenSubKey(RUN_KEY, writable: true) ?? Registry.CurrentUser.CreateSubKey(RUN_KEY, writable: true);

        var exePath = Application.ExecutablePath;
        key.SetValue(APP_NAME, $"\"{exePath}\"", RegistryValueKind.String);
    }

    public static void Uninstall()
    {
        using var key = Registry.CurrentUser.OpenSubKey(RUN_KEY, writable: true);
        if (key?.GetValue(APP_NAME) != null)
            key.DeleteValue(APP_NAME);
    }

    private static bool HandleCommandLine()
    {
        var args = Environment.GetCommandLineArgs();

        if (args.Length <= 1)
            return false;

        var cmd = args[1].TrimStart('/', '-').ToLower();

        if (cmd == "install")
        {
            Install();
            return true;
        }

        if (cmd == "uninstall")
        {
            Uninstall();
            return true;
        }

        return false;
    }

    public void Dispose()
    {
        _icon.Visible = false;
        _icon.Dispose();
    }
}