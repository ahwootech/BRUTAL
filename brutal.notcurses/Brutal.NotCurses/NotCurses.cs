namespace Brutal.NotCursesApi;

/// <summary>
/// Managed entry point for the notcurses API. The generated P/Invoke surface lives in the
/// nested <c>PInvoke</c> class (see <c>Generated/NotCurses.gen.cs</c>); hand-written convenience
/// wrappers go here.
/// </summary>
public static partial class NotCurses
{
    private const string Dll = "notcurses-core";

    /// <summary>The running notcurses library version, e.g. "3.0.17".</summary>
    public static string Version => PInvoke.notcurses_version();
}
