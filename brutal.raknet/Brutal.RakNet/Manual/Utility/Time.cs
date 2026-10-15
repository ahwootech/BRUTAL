using System.Diagnostics;

namespace Brutal.RakNetApi.Utility;

/// <summary>
/// Time-based functions for dealing with RakNet timestamps.
/// </summary>
public static class Time
{
    /// <summary>
    /// Computes the current timestamp in raknet units (milliseconds) based on the system's high-resolution
    /// performance counter and its frequency, ensuring precise time measurements.
    /// The result is returned in host byte order.
    /// </summary>
    ///
    public static long RakNetTimeMs() => (long)(Stopwatch.GetTimestamp() * RakNetTimeUnits / Stopwatch.Frequency);

    public static double SecondsFromRakNetTimestamp(long rakNetTimestamp) => rakNetTimestamp / RakNetTimeUnits;

    public static double TimestampNowSeconds() => (double)Stopwatch.GetTimestamp() / Stopwatch.Frequency;

    private const double RakNetTimeUnits = 1000.0d; // Milliseconds
}
