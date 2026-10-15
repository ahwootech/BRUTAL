using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using Brutal.Logging;
using Brutal.Monitor.Common;
using Brutal.Monitor.Logging;
using Microsoft.Extensions.Logging;

namespace Brutal.Monitor
{
    public class Monitor : IDisposable
    {
        private const int ThrottleExpirationMs = 10000; // Minimum milliseconds between first-chance collections
        private const int TimeOutMs = 1000; // Timeout for subprocess command acknowledgements
        private const int DefaultDumpTimeOutMs = 60000; // Matches CollectorOptions.DumpTimeoutMs

        // Bounded, so a best-effort dump still writing cannot make shutdown look hung
        private const int ShutdownGraceMs = 2000;

        private Process? _monitorProcess;
        private ProcessResponseReader? _responses;
        private long _nextFirstChance; // Earliest TickCount64 the next first-chance collection may start
        private volatile bool _firstChancePending;
        private volatile bool _subprocessExited;

        // Set before the subprocess is told to stop, so a crash handler already past its guard turns back
        private volatile bool _stopping;

        // Captured the moment the subprocess exits, so reading it later cannot race or throw
        private volatile int _subprocessExitCode = -1;
        private readonly LogCategory _monitorLog;
        private readonly string _name;

        /// <summary>The ILoggerProvider this Monitor logs through, owned and disposed by it.</summary>
        public MonitorLoggerProvider LogProvider { get; }

        private CollectorOptions? _collectorOptions = null;

        // Tracked via the Exited event so the first-chance path checks a field, not the process
        public bool SubprocessRunning => _monitorProcess != null && !_subprocessExited;

        /// <summary>Exit code of the subprocess once it has exited, or -1 while it is still running.</summary>
        public int SubprocessExitCode => _subprocessExitCode;

        /// <summary>
        /// The name (like "Gruntz.client") plus this run's start time and pid names every
        /// file this run produces, so instances sharing a folder never collide. It must be
        /// usable as a plain file name. Messages below minimumLevel are dropped before
        /// anything is formatted, which is where trace spam gets expensive.
        /// </summary>
        public Monitor(string name, LogLevel minimumLevel = LogLevel.Trace)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);

            // The name seeds file names and retention globs, so wildcards or separators could sweep others' files
            if (name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 || name.IndexOfAny(['*', '?', '/', '\\']) >= 0)
                throw new ArgumentException(
                    $"Monitor name '{name}' must be usable as a plain file name, without wildcards or separators.",
                    nameof(name)
                );

            _name = name;
            _monitorLog = LogCategory.Make("Monitor");
            LogProvider = new MonitorLoggerProvider(minimumLevel);

            Start();
        }

        public void Dispose()
        {
            Stop();

            LogProvider.Dispose();
        }

        public void AddLogger(LoggerOptions loggerOptions)
        {
            // In-process logging, so this works with or without the subprocess
            LogProvider.Configure(loggerOptions, _name);

            // An unusable path disables file logging rather than failing, so it is reported here
            if (LogProvider.LogFilePath is null)
                _monitorLog.Warning(
                    $"Monitor could not open a log file in '{loggerOptions.LogDirectory}'. "
                        + "File logging is disabled for this session."
                );

            // Read once: Stop can null the field between this and the write
            var process = _monitorProcess;
            if (process != null && !_subprocessExited && LogProvider.CrashTailPath is not null)
            {
                process.WriteLineSync($"LogTail\t{LogProvider.CrashTailPath}");
                _monitorLog.Info($"Monitor subprocess log tail: {WaitFor("LogTail", TimeOutMs) ?? "no response"}.");
            }
        }

        public void AddCollector(CollectorOptions collectorOptions)
        {
            // The game creates the directory; resolved to a full path so the subprocess's own cwd never matters
            collectorOptions.DumpPath = Path.GetFullPath(collectorOptions.DumpPath);
            if (!Directory.Exists(collectorOptions.DumpPath))
                throw new DirectoryNotFoundException($"Dump directory '{collectorOptions.DumpPath}' does not exist.");

            _collectorOptions = collectorOptions;

            // Detach first, so configuring twice replaces the handlers instead of doubling them
            DetachCollectorHandlers();
            if (_collectorOptions.Value.FirstChance != DumpType.None)
                AppDomain.CurrentDomain.FirstChanceException += OnFirstChance;
            if (_collectorOptions.Value.LastChance != DumpType.None)
                AppDomain.CurrentDomain.UnhandledException += OnLastChance;

            // Read once: Stop can null the field between this and the write
            var process = _monitorProcess;
            if (process == null || _subprocessExited)
                return;

            // Tab-separated because dump paths contain spaces
            process.WriteLineSync(
                $"AddCollector\t{collectorOptions.DumpPath}\t{(int)collectorOptions.FirstChance}"
                    + $"\t{(int)collectorOptions.LastChance}\t{collectorOptions.KeepCount}"
                    + $"\t{collectorOptions.DumpTimeoutMs}"
            );
            _monitorLog.Info($"Monitor subprocess collector: {WaitFor("AddCollector", TimeOutMs) ?? "no response"}.");
        }

        private void Start()
        {
            var rid = "win-x64";
            if (OperatingSystem.IsLinux())
                rid = "linux-x64";
            else if (OperatingSystem.IsMacOS())
                rid = "osx-arm64";

            var thisDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            var subprocessName = "Brutal.Monitor.Subprocess";
            var extension = OperatingSystem.IsWindows() ? ".exe" : "";

            var monitorExe = FindSubprocessExecutable(thisDirectory, rid, subprocessName + extension);
            if (monitorExe is null)
            {
                _monitorLog.Error(
                    $"Brutal.Monitor subprocess was not found beside the application or in "
                        + $"runtimes/{rid}/native. Crash dump collection is disabled."
                );
                return;
            }

            _monitorLog.Info($"Running Monitor subprocess from {thisDirectory}.");
            var startInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = monitorExe,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = thisDirectory,
            };

            // The subprocess names its dumps and tails from these, matching this run's log
            startInfo.ArgumentList.Add($"{Environment.ProcessId}");
            startInfo.ArgumentList.Add(_name);
            startInfo.ArgumentList.Add(MonitorFileNames.ProcessStamp);

            try
            {
                _monitorProcess = Process.Start(startInfo);
            }
            catch (Win32Exception)
            {
                _monitorProcess = null;
            }

            if (_monitorProcess == null)
            {
                _monitorLog.Warning(
                    $"Monitor subprocess ({monitorExe}) could not be started. "
                        + "Falling back to logging and crash handling from the main process."
                );
                return;
            }

            // Subscribed before events are enabled, or an already-dead subprocess fires Exited into no handler
            _subprocessExited = false;
            _monitorProcess.Exited += OnMonitorExit;
            _monitorProcess.EnableRaisingEvents = true;

            // Owns the only reader of the subprocess's stdout
            _responses = new ProcessResponseReader(_monitorProcess);

            _monitorLog.Info("Monitor subprocess started successfully");

            // Redirect the error stream to Log as Errors instead
            _monitorProcess
                .StandardError.ReadToEndAsync()
                .ContinueWith(task =>
                {
                    // Touching Exception observes a torn-down stream instead of raising UnobservedTaskException
                    if (task.Exception is not null || !task.IsCompletedSuccessfully)
                        return;

                    var errorOutput = task.Result;
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        _monitorLog.Warning($"Monitor subprocess error output: {errorOutput}");
                    }
                });
        }

        public void Stop()
        {
            // Closes the collect paths first, so a handler that entered before this cannot
            // write a command to a subprocess that is already on its way out
            _stopping = true;

            // Even when no subprocess started, or the handlers would root this Monitor for the process lifetime
            DetachCollectorHandlers();

            var process = _monitorProcess;
            if (process != null)
            {
                process.Exited -= OnMonitorExit;

                // This runs from Dispose, so shutting the subprocess down must always finish
                try
                {
                    if (!_subprocessExited)
                    {
                        process.WriteLineSync("Stop");
                        _monitorLog.Info($"Monitor subprocess stop: {WaitFor("Stop", TimeOutMs) ?? "no response"}.");
                    }

                    // A first-chance dump still writing is best effort, so shutdown abandons it
                    // rather than waiting out its whole budget and looking hung
                    if (process.WaitForExit(ShutdownGraceMs))
                        RecordExit(process);
                    else
                        Terminate(process);
                }
                catch (Exception) { }
                finally
                {
                    _responses?.Dispose();
                    _responses = null;
                    process.Dispose();
                    _monitorProcess = null;
                }
            }
        }

        private void RecordExit(Process process)
        {
            // Safe to read here: the wait returning means it has exited
            _subprocessExitCode = process.ExitCode;
            if (_subprocessExitCode != 0)
                _monitorLog.Error($"Monitor process {process.Id} exited with error {_subprocessExitCode}");
            else
                _monitorLog.Info($"Monitor process {process.Id} exited successfully.");
        }

        // The subprocess can exit before the kill lands, so Kill throwing is normal and the wait is bounded
        private void Terminate(Process process)
        {
            _monitorLog.Info($"Monitor process {process.Id} exit timeout. Force termination.");

            try
            {
                process.Kill(true);
            }
            catch (Exception) { }

            // Kill is asynchronous, and touching ExitCode before it lands throws
            try
            {
                if (process.WaitForExit(TimeOutMs))
                    RecordExit(process);
                else
                    _monitorLog.Warning($"Monitor process {process.Id} did not exit after being terminated.");
            }
            catch (Exception) { }
        }

        // Removing a handler that was never added is a no-op, so this is safe to call any time
        private void DetachCollectorHandlers()
        {
            AppDomain.CurrentDomain.FirstChanceException -= OnFirstChance;
            AppDomain.CurrentDomain.UnhandledException -= OnLastChance;
        }

        private void OnMonitorExit(object? sender, EventArgs e)
        {
            _subprocessExited = true;

            // Nothing may escape a runtime callback; a dead subprocess costs crash dumps, not the application
            try
            {
                // The sender is the process that just exited, so this never races Stop for the field
                if (sender is Process exited)
                    _subprocessExitCode = exited.ExitCode;

                _monitorLog.Warning(
                    $"Monitor subprocess exited early with exit code {_subprocessExitCode}. "
                        + "Crash dump collection is disabled for the rest of this session."
                );
            }
            catch (Exception) { }
        }

        private void OnFirstChance(object? sender, FirstChanceExceptionEventArgs e)
        {
            // Runs on every exception in the process, so the throttled path is a read and a compare
            var now = Environment.TickCount64;
            var next = Volatile.Read(ref _nextFirstChance);
            if (now < next)
                return;

            // One winner per window; a loser was beaten by a concurrent exception this same instant
            if (Interlocked.CompareExchange(ref _nextFirstChance, now + ThrottleExpirationMs, next) != next)
                return;

            if (_collectorOptions == null || _collectorOptions.Value.FirstChance == DumpType.None)
                return;

            if (!SubprocessRunning)
                return;

            try
            {
                CollectFirstChanceDump(e.Exception);
            }
            catch (Exception) { }
        }

        private void OnLastChance(object? sender, UnhandledExceptionEventArgs e)
        {
            // A main-thread crash runs this Monitor's Dispose on the way out, which would retire the ring
            LogProvider.PreserveCrashTail();

            if (_collectorOptions == null || _collectorOptions.Value.LastChance == DumpType.None)
                return;

            // Guarded so a throwing ToString on the dying exception cannot suppress the dump
            try
            {
                _monitorLog.Error($"Unhandled exception {e.ExceptionObject}.");
            }
            catch (Exception) { }

            if (!SubprocessRunning)
                return;

            // Unthrottled: sharing the first-chance permit let a benign throw skip the real dump
            try
            {
                CollectLastChanceDump();
            }
            catch (Exception) { }
        }

        /// <summary>Commands are serial, so the budget covers a first-chance dump ahead of us, if enabled.</summary>
        internal static int LastChanceWait(CollectorOptions? collectorOptions)
        {
            var dumpTimeOut = collectorOptions?.DumpTimeoutMs ?? DefaultDumpTimeOutMs;
            var firstChanceCanQueue = collectorOptions is { } options && options.FirstChance != DumpType.None;

            return firstChanceCanQueue ? dumpTimeOut * 2 + TimeOutMs : dumpTimeOut + TimeOutMs;
        }

        private int LastChanceWaitMs => LastChanceWait(_collectorOptions);

        private string? WaitFor(string command, int timeOut) => _responses?.WaitFor(command, timeOut);

        private void CollectFirstChanceDump(Exception exception)
        {
            // Read once: Stop can null the field between this and the write
            var process = _monitorProcess;
            if (_stopping || process == null || _subprocessExited)
                return;

            // One dump in flight at a time, or a burst of throws pushes the fatal dump past its wait budget
            if (_firstChancePending)
            {
                if (WaitFor("FirstChance", 0) is null)
                    return;
                _firstChancePending = false;
            }

            // Never wait: the throwing thread is not dying, so blocking it is a frame hitch for nothing
            process.WriteLineSync("FirstChance");
            _firstChancePending = true;

            // Formatted only for the exception being dumped, and a throwing ToString costs the line, not the dump
            try
            {
                _monitorLog.Error($"First chance dump requested for {exception}.");
            }
            catch (Exception) { }
        }

        private void CollectLastChanceDump()
        {
            // Read once: Stop can null the field between the check and the write
            var process = _monitorProcess;

            // A subprocess already told to stop will never answer, and waiting on it would stall the dying process
            if (_stopping || process == null || _subprocessExited)
            {
                _monitorLog.Warning("Last chance dump: the monitor subprocess is shutting down or gone.");
                return;
            }

            // This wait is what keeps the dying process alive long enough to be dumped
            process.WriteLineSync("LastChance");
            LogCollectResponse("Last chance dump", WaitFor("LastChance", LastChanceWaitMs));
        }

        private void LogCollectResponse(string kind, string? response)
        {
            if (string.IsNullOrEmpty(response))
            {
                _monitorLog.Warning($"{kind}: no response from the monitor subprocess.");
                return;
            }

            if (response.StartsWith("Failed", StringComparison.Ordinal) || response == "timed out")
                _monitorLog.Warning($"{kind}: {response}.");
            else
                _monitorLog.Info($"{kind}: {response}.");
        }

        /// <summary>
        /// Locate the subprocess executable: beside the app for local builds, or under
        /// runtimes/&lt;rid&gt;/native as the package delivers it. Returns null if neither exists.
        /// </summary>
        private static string? FindSubprocessExecutable(string baseDirectory, string rid, string fileName)
        {
            var beside = Path.Combine(baseDirectory, fileName);
            if (File.Exists(beside))
                return beside;

            var packaged = Path.Combine(baseDirectory, "runtimes", rid, "native", fileName);
            return File.Exists(packaged) ? packaged : null;
        }
    }
}
