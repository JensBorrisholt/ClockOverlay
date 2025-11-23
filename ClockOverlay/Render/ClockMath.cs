namespace ClockOverlay.Render;
using System;

public static class ClockMath
{
    public const double MILLISECONDS_IN_SECOND = 1000.0;    
    public const double SECONDS_IN_MINUTE = 60.0;
    public const double MINUTES_IN_HOUR = 60.0;
    public const int    HOURS_IN_CLOCK = 12;

    public const double TwoPi = Math.PI * 2;
    public const double HalfPi = Math.PI / 2;

    public static double SecondsAngle(DateTime t)
    {
        var s = t.Second + t.Millisecond / MILLISECONDS_IN_SECOND;
        return TwoPi * (s / SECONDS_IN_MINUTE) - HalfPi;
    }

    public static double MinutesAngle(DateTime t)
    {
        var s = t.Second + t.Millisecond / MILLISECONDS_IN_SECOND;
        var m = t.Minute + s / SECONDS_IN_MINUTE;
        return TwoPi * (m / MINUTES_IN_HOUR) - HalfPi;
    }

    public static double HoursAngle(DateTime t)
    {
        var s = t.Second + t.Millisecond / MILLISECONDS_IN_SECOND;
        var m = t.Minute + s / SECONDS_IN_MINUTE;
        var h = (t.Hour % HOURS_IN_CLOCK) + m / MINUTES_IN_HOUR;
        return TwoPi * (h / HOURS_IN_CLOCK) - HalfPi;
    }
}
