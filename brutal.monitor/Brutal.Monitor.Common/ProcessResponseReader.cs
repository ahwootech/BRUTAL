using System.Collections.Concurrent;
using System.Diagnostics;

namespace Brutal.Monitor.Common;

/// <summary>
/// Reads tagged response lines from a child process on its own thread and hands them out by
/// command name. Waiting is a memory poll against a deadline, so a silent child can never
/// block the caller the way reading the stream directly would. Each command has its own
/// slot, so concurrent waiters cannot consume each other's replies.
/// </summary>
internal sealed class ProcessResponseReader : IDisposable
{
    private const int PollMs = 5;

    private readonly Process _process;
    private readonly ConcurrentDictionary<string, string> _responses = new(StringComparer.Ordinal);
    private readonly Thread _thread;
    private volatile bool _stopping;

    // Set once stdout is closed, so waiters stop counting down a deadline nothing will answer
    private volatile bool _finished;

    public ProcessResponseReader(Process process)
    {
        _process = process;
        _thread = new Thread(ReadLoop) { Name = "Brutal.Monitor.ResponseReader", IsBackground = true };
        _thread.Start();
    }

    private void ReadLoop()
    {
        try
        {
            while (!_stopping)
            {
                // Blocks here, not in the caller, and ends when the child closes stdout
                var line = _process.StandardOutput.ReadLine();
                if (line is null)
                    break;

                if (TrySplitResponse(line, out var command, out var response))
                    _responses[command] = response;
            }
        }
        catch (Exception)
        {
            // The child went away mid-read; waiters give up as soon as they see this
        }
        finally
        {
            // Published after any final response, so a waiter that sees this still finds it
            _finished = true;
        }
    }

    /// <summary>
    /// Split "FirstChance OK path" into its command tag and the rest.
    /// </summary>
    internal static bool TrySplitResponse(string? line, out string command, out string response)
    {
        command = string.Empty;
        response = string.Empty;
        if (string.IsNullOrEmpty(line))
            return false;

        var space = line.IndexOf(' ');
        if (space < 0)
        {
            command = line;
            return true;
        }

        command = line[..space];
        response = line[(space + 1)..];
        return command.Length > 0;
    }

    /// <summary>
    /// Wait for this command's response, or null if none arrived before the timeout. Returns
    /// as soon as the child closes stdout, so a dead subprocess costs no wait at all.
    /// </summary>
    public string? WaitFor(string command, int timeOut)
    {
        var deadline = Environment.TickCount64 + timeOut;
        while (true)
        {
            if (_responses.TryRemove(command, out var response))
                return response;

            // A closed stdout or a disposed reader will never answer, so the rest of the deadline is a pure stall
            if (_finished || _stopping)
                return _responses.TryRemove(command, out var last) ? last : null;

            if (Environment.TickCount64 >= deadline)
                return null;

            Thread.Sleep(PollMs);
        }
    }

    public void Dispose()
    {
        _stopping = true;
    }
}
