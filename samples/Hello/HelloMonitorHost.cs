/*
 * HelloMonitorHost
 *
 * Starts the Monitor (a crash/log watchdog subprocess), logs a few lines to a file and prints them.
 */

#:package Ahwoo.Brutal.Monitor.Host@2026.10.3
#:package Ahwoo.Brutal.Monitor.Common@2026.10.3

// RIAN: We use this package for crash detection and dump collection at runtime.

using Brutal.Monitor.Common;
using Microsoft.Extensions.Logging;
using Monitor = Brutal.Monitor.Monitor;

Run();

static void Run()
{
    var logDirectory = Path.Combine(Path.GetTempPath(), "HelloMonitor");
    Directory.CreateDirectory(logDirectory);

    string? logFile;

    // Disposing the monitor flushes the log and stops the subprocess, so the log is read after this block.
    using (var monitor = new Monitor("HelloMonitor")) // Starts the watchdog subprocess.
    {
        monitor.AddLogger(new LoggerOptions { LogDirectory = logDirectory });

        var logger = monitor.LogProvider.CreateLogger("Hello");
        logger.LogInformation("Hello from the Monitor host!");
        for (var i = 0; i < 3; i++)
            logger.LogWarning("Tick {Tick}", i);

        logFile = monitor.LogProvider.LogFilePath;
        Console.WriteLine($"Subprocess running: {monitor.SubprocessRunning}");
    }

    Console.WriteLine($"Log written to {logFile}:");
    Console.WriteLine(File.ReadAllText(logFile!));
}
