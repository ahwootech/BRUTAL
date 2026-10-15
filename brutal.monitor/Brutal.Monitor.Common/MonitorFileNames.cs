using System.Diagnostics;
using System.Globalization;

namespace Brutal.Monitor.Common;

/// <summary>
/// Naming shared by everything one run produces: every file carries "&lt;name&gt;.&lt;start time&gt;.&lt;pid&gt;",
/// so a dump can be matched to its log and instances or reused pids never collide.
/// </summary>
internal static class MonitorFileNames
{
    // Local time; the dash keeps a run's suffix distinct from an archive's all-numeric "<yyMMdd>.<index>"
    internal const string StampFormat = "yyMMdd-HHmmss";

    /// <summary>This process's start time as a stamp; the subprocess is handed the host's, never its own.</summary>
    public static string ProcessStamp { get; } = Stamp(CurrentProcessStart());

    /// <summary>One run's file stem: "&lt;name&gt;.&lt;stamp&gt;.&lt;pid&gt;", the identity all its files carry.</summary>
    public static string Stem(string name, string stamp, int processId)
    {
        return $"{name}.{stamp}.{processId}";
    }

    /// <summary>Format a start time as a stem's timestamp part.</summary>
    public static string Stamp(DateTime startTime)
    {
        return startTime.ToString(StampFormat, CultureInfo.InvariantCulture);
    }

    /// <summary>True when this suffix part is a run stamp, so stray files never parse as runs.</summary>
    public static bool IsStamp(string part)
    {
        return DateTime.TryParseExact(part, StampFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
    }

    /// <summary>
    /// The dot-separated parts following "&lt;name&gt;." in a file's name, or null when the file
    /// doesn't belong to that name. Directory globs are not enough on their own, since
    /// "Gruntz.*" also matches Gruntz.client's files.
    /// </summary>
    public static string[]? OwnedSuffix(string fileName, string name)
    {
        var stem = Path.GetFileNameWithoutExtension(fileName);
        if (!stem.StartsWith(name + ".", StringComparison.Ordinal))
            return null;

        return stem[(name.Length + 1)..].Split('.');
    }

    /// <summary>Match an archive named "&lt;name&gt;.&lt;yyMMdd&gt;.&lt;index&gt;".</summary>
    public static bool TryParseArchive(string fileName, string name, out int timeStamp, out int index)
    {
        timeStamp = 0;
        index = 0;

        return OwnedSuffix(fileName, name) is { Length: 2 } suffix
            && int.TryParse(suffix[0], out timeStamp)
            && int.TryParse(suffix[1], out index);
    }

    private static DateTime CurrentProcessStart()
    {
        try
        {
            using var process = Process.GetCurrentProcess();
            return process.StartTime;
        }
        catch (Exception)
        {
            // A start time the OS will not give still has to name this run's files
            return DateTime.Now;
        }
    }
}
