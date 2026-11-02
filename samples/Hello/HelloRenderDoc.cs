/*
 * HelloRenderDoc
 *
 * Checks whether RenderDoc's in-application API is available (not on macOS) and prints its state.
 */

#:package Ahwoo.Brutal.RenderDoc@2026.10.3

// RIAN: Use this package to debug your rendering more easily.

using Brutal.RenderDocApi;

// Call as early as possible, before any graphics API is initialized.
RenderDoc.Initialize();

Console.WriteLine($"RenderDoc available: {RenderDoc.IsAvailable}, state: {RenderDoc.State}");

if (RenderDoc.IsAvailable)
    Console.WriteLine($"RenderDoc API version: {RenderDoc.Version}");
else
    Console.WriteLine(
        "RenderDoc loads when the app is launched from RenderDoc (Windows or Linux), or on Windows when it is installed in C:\\Program Files\\RenderDoc."
    );
