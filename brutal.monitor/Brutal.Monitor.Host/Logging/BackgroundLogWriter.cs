using System.Globalization;
using System.Text;
using System.Threading.Channels;
using Brutal.Monitor.Common;
using Microsoft.Extensions.Logging;

namespace Brutal.Monitor.Logging;

/// <summary>
/// Writes log lines to file from a background thread fed by a bounded channel, so a log
/// call only ever touches memory. On overflow the oldest lines are dropped and counted.
/// Custom formatting runs on the writer thread, never the caller's.
/// </summary>
internal sealed class BackgroundLogWriter : IDisposable
{
    private const int QueueCapacity = 8192;
    private const int DrainWaitMs = 100;

    // Platform newline as UTF-8, appended after each encoded line
    private static readonly byte[] NewLineBytes = Encoding.UTF8.GetBytes(Environment.NewLine);

    // A raw line (null category) skips the formatter: markers and recovery notes
    private readonly record struct Entry(LogLevel Level, string? Category, string Message);

    private readonly Channel<Entry> _queue;

    private FileStream? _file;
    private byte[] _lineBuffer = new byte[8192]; // Writer-thread only, grown geometrically to fit the largest line seen
    private Thread? _thread;
    private long _totalDropped;
    private long _reportedDropped; // Writer-thread only: drops already reported into the log
    private long _linesWritten;
    private long _bytesWritten;
    private long _linesDiscarded; // Writer-thread only: lines drained with no file to take them
    private volatile bool _writerFailed;
    private int _disposed;

    public BackgroundLogWriter()
    {
        // DropOldest counts each eviction, and a completed channel refuses writes quietly.
        // One atomic per drop: the writer thread works out what is new to report from the total
        _queue = Channel.CreateBounded<Entry>(
            new BoundedChannelOptions(QueueCapacity)
            {
                FullMode = BoundedChannelFullMode.DropOldest,
                SingleReader = true,
            },
            _ => Interlocked.Increment(ref _totalDropped)
        );
    }

    /// <summary>Lines waiting for the writer thread, cheap enough to poll per frame.</summary>
    public int QueueDepth => _queue.Reader.Count;

    /// <summary>Lines the queue holds before the oldest are dropped.</summary>
    public int Capacity => QueueCapacity;

    /// <summary>Lines written to the log file so far.</summary>
    public long LinesWritten => Interlocked.Read(ref _linesWritten);

    /// <summary>UTF-8 bytes written to the log file so far.</summary>
    public long BytesWritten => Interlocked.Read(ref _bytesWritten);

    /// <summary>Lines lost to queue overflow so far.</summary>
    public long LinesDropped => Interlocked.Read(ref _totalDropped);

    /// <summary>Lines that reached the writer thread with no log file to take them.</summary>
    public long LinesDiscarded => Interlocked.Read(ref _linesDiscarded);

    /// <summary>True once the log file was given up after a write or flush failure.</summary>
    public bool WriterFailed => _writerFailed;

    /// <summary>Queue a raw line. Never blocks or throws; drops the oldest line when full.</summary>
    public void Add(string message)
    {
        _queue.Writer.TryWrite(new Entry(LogLevel.None, null, message));
    }

    /// <summary>
    /// Queue a log message. Formatting happens later on the writer thread.
    /// </summary>
    public void Add(LogLevel level, string category, string message)
    {
        _queue.Writer.TryWrite(new Entry(level, category, message));
    }

    /// <summary>Path being written to. Null if no file could be opened.</summary>
    public string? LogFilePath { get; private set; }

    /// <summary>Optional line formatter, read on the writer thread so it never costs a caller.</summary>
    public Func<LogLevel, string, string, string>? LogFormatter { get; set; }

    /// <summary>
    /// Sweep dead runs' leftovers, then open this run's log file ("&lt;name&gt;.&lt;stamp&gt;.&lt;pid&gt;.log")
    /// and start the writer thread. The directory must already exist.
    /// </summary>
    public void Open(LoggerOptions options, string name)
    {
        if (_thread is not null)
            throw new InvalidOperationException("BackgroundLogWriter is already open");

        // The caller creates the directory; resolved to a full path so the subprocess's own cwd never matters
        var directory = Path.GetFullPath(options.LogDirectory);
        if (!Directory.Exists(directory))
            throw new DirectoryNotFoundException($"Log directory '{directory}' does not exist.");

        // Nothing past this point may throw into startup; housekeeping is best effort
        try
        {
            SweepDeadRuns(directory, name, options.MaxArchives);
        }
        catch (Exception) { }

        var stem = MonitorFileNames.Stem(name, MonitorFileNames.ProcessStamp, Environment.ProcessId);
        var logFilePath = Path.Combine(directory, $"{stem}.log");
        try
        {
            // Unix would let the open succeed on a held file, so ownership is probed explicitly
            if (File.Exists(logFilePath) && !LogArchiver.IsUnheld(logFilePath))
                throw new IOException($"{logFilePath} already has a live writer");

            // A raw stream: lines are encoded to UTF-8 once here, so a StreamWriter would only re-encode
            _file = new FileStream(logFilePath, FileMode.Create, FileAccess.Write, FileShare.Read);
            LogFilePath = logFilePath;
        }
        catch (IOException) { }
        catch (UnauthorizedAccessException) { }

        var flushInterval = Math.Max(options.FlushIntervalMs, DrainWaitMs);
        _thread = new Thread(() => WriteLoop(flushInterval)) { Name = "Brutal.Monitor.LogWriter", IsBackground = true };
        _thread.Start();

        // Hosts that never dispose the Monitor would otherwise lose the queue tail
        AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
    }

    private void OnProcessExit(object? sender, EventArgs e)
    {
        Dispose();
    }

    /// <summary>
    /// Recover dead runs' crash tails and archive their logs; files held by a live holder are left alone.
    /// </summary>
    private void SweepDeadRuns(string directory, string name, int maxArchives)
    {
        foreach (var ring in Directory.GetFiles(directory, $"{name}.*.ring"))
        {
            // A ring is named <name>.<stamp>.<pid>.log.ring, so two extensions off gives the stem
            var stem = Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(ring));
            if (!IsRunFile(stem + ".log", name) || !LogArchiver.IsUnheld(ring))
                continue;

            var recovered = CrashTailSnapshot.TryWrite(ring, Path.Combine(directory, $"{stem}.previous-crash.log"));
            if (recovered > 0)
                Add($"[Brutal.Monitor] recovered {recovered} log lines from {Path.GetFileName(ring)}");

            // A failed snapshot leaves the only copy of the tail in the ring; keep it for the next run to retry
            if (recovered == CrashTailSnapshot.SnapshotFailed)
                continue;

            try
            {
                File.Delete(ring);
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
        }

        foreach (var log in Directory.GetFiles(directory, $"{name}.*.log"))
        {
            // A locked log fails rotation and belongs to a live instance anyway
            if (IsRunFile(log, name))
                LogArchiver.TryRotate(log, name, maxArchives);
        }

        PruneRecoveredTails(directory, name, maxArchives);
    }

    /// <summary>
    /// Tails recovered from dead runs pile up beside the logs, so they get the same retention
    /// as archives: the newest maxArchives are kept, and zero keeps every one.
    /// </summary>
    private static void PruneRecoveredTails(string directory, string name, int maxArchives)
    {
        if (maxArchives <= 0)
            return;

        var tails = new List<FileInfo>();
        foreach (var path in Directory.GetFiles(directory, $"{name}.*.log"))
        {
            if (IsRecoveredTail(path, name))
                tails.Add(new FileInfo(path));
        }

        foreach (var expired in tails.OrderByDescending(tail => tail.LastWriteTimeUtc).Skip(maxArchives))
        {
            try
            {
                expired.Delete();
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
        }
    }

    // "<name>.<stamp>.<pid>.previous-crash.log" and "<name>.<stamp>.<pid>.<timestamp>.abnormal-exit.log"
    private static bool IsRecoveredTail(string fileName, string name)
    {
        return MonitorFileNames.OwnedSuffix(fileName, name) is { Length: >= 3 } suffix
            && MonitorFileNames.IsStamp(suffix[0])
            && int.TryParse(suffix[1], out _)
            && suffix[^1] is "previous-crash" or "abnormal-exit";
    }

    // Matches "<name>.<stamp>.<pid>" and nothing looser, so a stray user file is never archived
    private static bool IsRunFile(string fileName, string name)
    {
        return MonitorFileNames.OwnedSuffix(fileName, name) is { Length: 2 } suffix
            && MonitorFileNames.IsStamp(suffix[0])
            && int.TryParse(suffix[1], out _);
    }

    private void WriteLoop(int flushInterval)
    {
        // Nothing may escape: an unhandled exception here would take the game down
        try
        {
            DrainLoop(flushInterval);
        }
        catch (Exception) { }
        finally
        {
            // The writer thread owns closing the file, so a Dispose that gave up waiting can't leak it
            DisableWriter();
        }
    }

    private void DrainLoop(int flushInterval)
    {
        var reader = _queue.Reader;
        var pendingFlush = false;
        var lastFlush = Environment.TickCount64;

        // One outstanding wait at a time, kept across timeouts so idle flushes still happen
        Task<bool>? waiting = null;
        while (true)
        {
            waiting ??= reader.WaitToReadAsync().AsTask();

            // The timeout is only there to flush what is buffered, so an idle writer waits for a line
            var waitMs = pendingFlush ? DrainWaitMs : Timeout.Infinite;
            if (waiting.Wait(waitMs))
            {
                var hasLines = waiting.Result;
                waiting = null;
                if (!hasLines)
                    break; // Completed and fully drained

                // Bounded, so producers that outpace the writer can't starve the drop report and flush below
                var batch = 0;
                while (batch++ < QueueCapacity && reader.TryRead(out var entry))
                    WriteLine(entry);
                pendingFlush = true;
            }

            if (ReportDrops())
                pendingFlush = true;

            // Flush is page-cache only, so a short cadence is cheap
            if (pendingFlush && Environment.TickCount64 - lastFlush >= flushInterval)
            {
                Flush();
                pendingFlush = false;
                lastFlush = Environment.TickCount64;
            }
        }

        ReportDrops();
        Flush();
    }

    private void WriteLine(in Entry entry)
    {
        // Counted, so a file that died mid-session shows in the stats instead of losing lines silently
        if (_file is null)
        {
            _linesDiscarded++;
            return;
        }

        var line = FormatLine(entry);
        try
        {
            // One UTF-8 pass per line: encode into a reusable buffer, and the same pass yields the byte stat
            var maxBytes = Encoding.UTF8.GetMaxByteCount(line.Length) + NewLineBytes.Length;
            if (_lineBuffer.Length < maxBytes)
            {
                var doubled = (int)Math.Min((long)_lineBuffer.Length * 2, Array.MaxLength);
                _lineBuffer = new byte[Math.Max(maxBytes, doubled)];
            }

            var byteCount = Encoding.UTF8.GetBytes(line.AsSpan(), _lineBuffer);
            NewLineBytes.CopyTo(_lineBuffer.AsSpan(byteCount));
            byteCount += NewLineBytes.Length;
            _file.Write(_lineBuffer, 0, byteCount);

            // Only this thread writes these; readers take a whole 64-bit value via Interlocked.Read
            _linesWritten++;
            _bytesWritten += byteCount;
        }
        catch (Exception)
        {
            // A full or disconnected disk gives up the file, not the process
            FailWriter();
        }
    }

    private string FormatLine(in Entry entry)
    {
        // A custom formatter runs here so its strings never cost a game thread
        var formatter = LogFormatter;
        if (entry.Category is null || formatter is null)
            return entry.Message;

        try
        {
            // A formatter returning null would otherwise disable the log file for good
            return formatter(entry.Level, entry.Category, entry.Message) ?? entry.Message;
        }
        catch (Exception)
        {
            // A broken formatter costs its decoration, not the log
            return entry.Message;
        }
    }

    private void Flush()
    {
        try
        {
            _file?.Flush();
        }
        catch (Exception)
        {
            FailWriter();
        }
    }

    // A failure gives up the file like a normal close does, but leaves a mark the stats can show
    private void FailWriter()
    {
        _writerFailed = true;
        DisableWriter();
    }

    // Give up on the log file and keep draining, so producers never block or throw
    private void DisableWriter()
    {
        var file = Interlocked.Exchange(ref _file, null);
        if (file is null)
            return;

        try
        {
            file.Dispose();
        }
        catch (Exception) { }
    }

    // True when a report was written, since that line needs flushing like any other
    private bool ReportDrops()
    {
        var dropped = Interlocked.Read(ref _totalDropped) - _reportedDropped;
        if (dropped <= 0)
            return false;

        WriteLine(new Entry(LogLevel.None, null, $"[Brutal.Monitor] dropped {dropped} log messages (queue overflow)"));
        _reportedDropped += dropped;
        return true;
    }

    public void Dispose()
    {
        // Idempotent - reached from both Monitor disposal and the ProcessExit hook
        if (Interlocked.Exchange(ref _disposed, 1) != 0)
            return;

        AppDomain.CurrentDomain.ProcessExit -= OnProcessExit;
        _queue.Writer.TryComplete();

        // Bounded so a stuck disk can't stall process exit; the writer thread closes the file either way
        if (_thread is null)
            DisableWriter();
        else
            _thread.Join(TimeSpan.FromSeconds(2));
    }
}

/// <summary>
/// Moves a finished log into an Archives folder as &lt;archive name&gt;.yyMMdd.n.log,
/// keeping at most maxArchives per name (zero keeps all).
/// </summary>
internal static class LogArchiver
{
    // FileShare.None maps to an exclusive flock on Unix, so a live holder conflicts on every platform
    internal static bool IsUnheld(string path)
    {
        try
        {
            using var probe = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            return true;
        }
        catch (FileNotFoundException)
        {
            // Deleted between the caller's existence check and this probe: no file, no holder
            return true;
        }
        catch (IOException)
        {
            return false;
        }
        catch (UnauthorizedAccessException)
        {
            return false;
        }
    }

    /// <summary>Returns false when the log could not be archived, so the caller can move on.</summary>
    public static bool TryRotate(string logFilePath, string archiveName, int maxArchives)
    {
        try
        {
            Rotate(logFilePath, archiveName, maxArchives);
            return true;
        }
        catch (IOException)
        {
            return false;
        }
        catch (UnauthorizedAccessException)
        {
            return false;
        }
    }

    public static void Rotate(string logFilePath, string archiveName, int maxArchives)
    {
        if (!File.Exists(logFilePath))
            return;

        // Unix happily renames an open file, so a held log must be refused here, not by the move
        if (!IsUnheld(logFilePath))
            throw new IOException($"{logFilePath} is held open by a live instance");

        var directory = Path.GetDirectoryName(logFilePath)!;
        var currentFile = new FileInfo(logFilePath);
        var currentFileTimeStamp = currentFile.LastWriteTime.ToString("yyMMdd", CultureInfo.InvariantCulture);
        var archiveDirectory = Path.Combine(directory, "Archives");
        var extension = Path.GetExtension(logFilePath);

        if (!Directory.Exists(archiveDirectory))
            Directory.CreateDirectory(archiveDirectory);

        // Only this name's own archives, so names sharing a folder keep separate histories
        var archives = new List<(string Path, int TimeStamp, int Index)>();
        foreach (var path in Directory.GetFiles(archiveDirectory, $"{archiveName}.*{extension}"))
        {
            if (MonitorFileNames.TryParseArchive(path, archiveName, out var timeStamp, out var index))
                archives.Add((path, timeStamp, index));
        }
        archives.Sort((a, b) => a.TimeStamp != b.TimeStamp ? a.TimeStamp - b.TimeStamp : a.Index - b.Index);

        // Suffix an index when today already has an archive
        var archiveIndex = 0;
        foreach (var archive in archives)
        {
            if (archive.TimeStamp.ToString("D6") == currentFileTimeStamp)
                archiveIndex = Math.Max(archiveIndex, archive.Index + 1);
        }

        // Another instance sweeping the same folder can claim an index first, so a collision retries the next
        for (var attempt = 0; ; attempt++)
        {
            var archivePath = Path.Combine(
                archiveDirectory,
                $"{archiveName}.{currentFileTimeStamp}.{archiveIndex}{extension}"
            );
            try
            {
                currentFile.MoveTo(archivePath);
                break;
            }
            catch (IOException) when (attempt < 5 && File.Exists(archivePath))
            {
                archiveIndex++;
            }
        }

        if (maxArchives <= 0)
            return;

        // Counts the archive just added, so the folder settles at maxArchives
        var toDelete = archives.Count + 1 - maxArchives;
        for (int i = 0; i < toDelete && i < archives.Count; i++)
        {
            // A stale archive we cannot delete is not worth failing startup over
            try
            {
                File.Delete(archives[i].Path);
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
        }
    }
}
