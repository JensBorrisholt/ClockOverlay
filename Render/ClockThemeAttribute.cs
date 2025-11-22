namespace ClockOverlay.Render;

using System;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class ClockThemeAttribute(ClockTheme theme) : Attribute
{
    public ClockTheme Theme { get; } = theme;
}
