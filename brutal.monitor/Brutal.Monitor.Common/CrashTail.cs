using System.Buffers;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Text.Unicode;

namespace Brutal.Monitor.Common;

/// <summary>
/// Ring buffer of the most recent log lines in a memory-mapped file, so the log tail
/// survives a crash that kills the host before it flushes. Written by the host, read by
/// the monitor subprocess.
/// </summary>
internal sealed class CrashTailRing : IDisposable
{
    // Layout: header, then slotCount slots of [long seq][int length][utf8 payload]
    internal const long Magic = 0x4C49_4154_5242_4D42;
    internal const int Version = 1;
    internal const int HeaderSize = 64;
    internal const int SlotHeaderSize = 12;

    internal const int DefaultSlotCount = 1024;

    // A logged exception's stack trace runs to several KB, and a clipped one is worth little here
    internal const int DefaultSlotSize = 4096;

    // Kept at the end of a slot so a clipped line says so rather than looking complete
    private static ReadOnlySpan<byte> TruncatedMarker => " [truncated]"u8;

    private readonly MemoryMappedFile _file;
    private readonly MemoryMappedViewAccessor _accessor;
    private readonly int _slotCount;
    private readonly int _slotSize;
    private long _sequence;
    private int _disposed;

    // Set when the host is dying, so disposal leaves the tail behind instead of retiring it
    private volatile bool _preserve;

    public string FilePath { get; }

    /// <summary>Total records ever written; the ring holds the most recent SlotCount.</summary>
    public long Sequence => Interlocked.Read(ref _sequence);

    public int SlotCount => _slotCount;
    public int SlotSize => _slotSize;

    public CrashTailRing(string filePath, int slotCount = DefaultSlotCount, int slotSize = DefaultSlotSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(slotCount, 1);

        // A slot has to hold its header, the truncation marker and some of a line
        ArgumentOutOfRangeException.ThrowIfLessThan(slotSize, SlotHeaderSize + TruncatedMarker.Length + 1);

        FilePath = filePath;
        _slotCount = slotCount;
        _slotSize = slotSize;

        // Shared so the subprocess can map the ring while we hold it open
        var stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
        var size = HeaderSize + (long)slotCount * slotSize;
        _file = MemoryMappedFile.CreateFromFile(
            stream,
            null,
            size,
            MemoryMappedFileAccess.ReadWrite,
            HandleInheritability.None,
            leaveOpen: false
        );
        _accessor = _file.CreateViewAccessor();

        _accessor.Write(0, Magic);
        _accessor.Write(8, Version);
        _accessor.Write(12, slotCount);
        _accessor.Write(16, slotSize);
    }

    /// <summary>
    /// Write a log line straight into the mapped memory, allocation-free and safe from any
    /// thread. A writer preempted for a full ring of messages can cost one line of tail.
    /// </summary>
    public unsafe void Write(string message)
    {
        var seq = Interlocked.Increment(ref _sequence);
        var slot = (int)((seq - 1) % _slotCount);
        var offset = HeaderSize + (long)slot * _slotSize;

        // Acquire/Release pins the mapping so a concurrent Dispose can't pull it from under us
        var handle = _accessor.SafeMemoryMappedViewHandle;
        byte* pointer = null;
        handle.AcquirePointer(ref pointer);
        try
        {
            // Seqlock write: invalidate the slot, fill it, then publish the new sequence
            var slotPointer = pointer + _accessor.PointerOffset + offset;

            // Full-fence store, so the payload below cannot reorder ahead of the invalidation
            Interlocked.Exchange(ref *(long*)slotPointer, 0);

            // Encoded short of the marker's room, so a clipped line is marked instead of lost quietly
            var payload = new Span<byte>(slotPointer + SlotHeaderSize, _slotSize - SlotHeaderSize);
            var status = Utf8.FromUtf16(message, payload[..^TruncatedMarker.Length], out _, out var length);
            if (status == OperationStatus.DestinationTooSmall)
            {
                TruncatedMarker.CopyTo(payload[length..]);
                length += TruncatedMarker.Length;
            }

            *(int*)(slotPointer + 8) = length;

            // No barrier needed here: this release store already orders the payload ahead of itself
            Volatile.Write(ref *(long*)slotPointer, seq);
        }
        finally
        {
            handle.ReleasePointer();
        }
    }

    /// <summary>Keep the ring on disposal, so a crash unwinding through the host's cleanup leaves its tail.</summary>
    public void Preserve()
    {
        _preserve = true;
    }

    public void Dispose()
    {
        // Idempotent - shutdown paths can overlap, and a second pass must not throw
        if (Interlocked.Exchange(ref _disposed, 1) != 0)
            return;

        // Only a clean exit retires the tail; a crash leaves it readable for the next run
        if (!_preserve)
        {
            // Invalidated first so nothing can be recovered even if the delete below fails
            try
            {
                _accessor.Write(0, 0L);
                _accessor.Flush();
            }
            catch (Exception) { }
        }

        _accessor.Dispose();
        _file.Dispose();

        if (_preserve)
            return;

        // Best effort - if the subprocess still maps it, the next instance's sweep removes it
        try
        {
            File.Delete(FilePath);
        }
        catch (IOException) { }
        catch (UnauthorizedAccessException) { }
    }
}

/// <summary>
/// Reads a CrashTailRing and writes its surviving records, oldest first, as plain text,
/// under a header saying how many lines these are and where the full log lives.
/// </summary>
public static class CrashTailSnapshot
{
    /// <summary>Nothing to recover: the ring is missing, foreign, or was cleanly retired.</summary>
    public const int NoTail = -1;

    /// <summary>The snapshot failed, so the ring may still hold a recoverable tail.</summary>
    public const int SnapshotFailed = -2;

    /// <summary>
    /// Returns the number of log lines recovered, NoTail, or SnapshotFailed. Writes no file
    /// when there is nothing to recover.
    /// </summary>
    public static int TryWrite(string ringPath, string outputPath)
    {
        try
        {
            if (!File.Exists(ringPath))
                return NoTail;

            using var stream = new FileStream(ringPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var file = MemoryMappedFile.CreateFromFile(
                stream,
                null,
                0,
                MemoryMappedFileAccess.Read,
                HandleInheritability.None,
                leaveOpen: false
            );
            using var accessor = file.CreateViewAccessor(0, 0, MemoryMappedFileAccess.Read);

            if (accessor.ReadInt64(0) != CrashTailRing.Magic || accessor.ReadInt32(8) != CrashTailRing.Version)
                return NoTail;
            var slotCount = accessor.ReadInt32(12);
            var slotSize = accessor.ReadInt32(16);
            if (slotCount <= 0 || slotSize <= CrashTailRing.SlotHeaderSize)
                return NoTail;

            var records = new List<(long Seq, string Line)>(slotCount);
            var payload = new byte[slotSize - CrashTailRing.SlotHeaderSize];

            for (int slot = 0; slot < slotCount; slot++)
            {
                var offset = CrashTailRing.HeaderSize + (long)slot * slotSize;

                // Seqlock read: a slot whose seq moves under us is mid-write, so skip it
                var seqBefore = accessor.ReadInt64(offset);
                if (seqBefore <= 0)
                    continue;

                // The seq read must land before the payload reads, or a torn line can pass the recheck
                Thread.MemoryBarrier();

                var length = accessor.ReadInt32(offset + 8);
                if (length <= 0 || length > payload.Length)
                    continue;

                accessor.ReadArray(offset + CrashTailRing.SlotHeaderSize, payload, 0, length);
                Thread.MemoryBarrier();
                if (accessor.ReadInt64(offset) != seqBefore)
                    continue;

                records.Add((seqBefore, Encoding.UTF8.GetString(payload, 0, length)));
            }

            records.Sort((a, b) => a.Seq.CompareTo(b.Seq));

            // An empty file would read as a lost tail rather than no tail
            if (records.Count == 0)
                return 0;

            using var writer = File.CreateText(outputPath);

            // These are only the last lines of a run, so say so and point at the whole log
            var logName = Path.GetFileNameWithoutExtension(ringPath);
            writer.WriteLine($"[Brutal.Monitor] the most recent {records.Count} log lines - full history in {logName}");

            foreach (var record in records)
                writer.WriteLine(record.Line);

            return records.Count;
        }
        catch (Exception)
        {
            // Best effort - a failed snapshot must never break dump collection
            return SnapshotFailed;
        }
    }
}
