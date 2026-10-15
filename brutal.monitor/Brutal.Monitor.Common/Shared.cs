namespace Brutal.Monitor.Common;

public enum DumpType
{
    None = 0,
    Triage,
    Mini,
    Full,
    Heap,
}

public struct CollectorOptions
{
    /// <summary>Directory dumps are written under, in FirstChance and LastChance subfolders. Must already exist.</summary>
    public string DumpPath = "";

    public DumpType FirstChance = DumpType.None;
    public DumpType LastChance = DumpType.None;

    public int KeepCount = 5; // number of dumps to keep

    /// <summary>
    /// Milliseconds allowed for writing a crash dump, which a dying host waits out.
    /// </summary>
    public int DumpTimeoutMs = 60000;

    public CollectorOptions() { }
}

public struct LoggerOptions
{
    /// <summary>Directory the log file ("&lt;name&gt;.&lt;stamp&gt;.&lt;pid&gt;.log") is created in. Must already exist.</summary>
    public string LogDirectory = "";

    /// <summary>
    /// How often buffered log lines are flushed to the OS page cache, bounding what a hard
    /// crash loses from the log file. Floors at 100ms.
    /// </summary>
    public int FlushIntervalMs = 100;

    /// <summary>
    /// Archived logs and recovered crash tails to retain per name. Zero keeps every one,
    /// which grows without bound, so the default is a real number a shipped game can live with.
    /// </summary>
    public int MaxArchives = 10;

    public LoggerOptions() { }
}
