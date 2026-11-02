/*
 * HelloLogging
 *
 * Sets up logging to the console and writes messages to the default and a named category.
 */

#:package Ahwoo.Brutal.Logging@2026.10.3

// RIAN: This is a very-very thin wrapper around Microsoft.Extensions.Logging, but it provides a simpler API and a default category for quick logging.

using Brutal.Logging;
using Microsoft.Extensions.Logging;
using static Brutal.Logging.DefaultCategory;

LogSystem.Initialize(builder =>
{
    builder.SetMinimumLevel(LogLevel.Trace);
    builder.AddConsole();
});

// The default "Log" category.
Log.Info("Hello from Brutal.Logging");
Log.Warning($"The answer is {42}");

// Named categories group messages by system.
var network = LogCategory.Make("Network");
network.Debug("Connecting...");
network.Error("Connection refused");
