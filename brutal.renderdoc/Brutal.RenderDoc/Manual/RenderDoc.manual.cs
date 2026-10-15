using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Brutal.RenderDocApi;

/// RenderDoc's <a href="https://renderdoc.org/docs/in_application_api.html">in-app API</a>.
public static unsafe partial class RenderDoc
{
    #region controller (helpers around the actual native API)

    public enum ControllerState
    {
        NotLoaded,
        LoadFail,
        LoadSuccess,
    }

    public static ControllerState State =>
        ApiLoaded
            ? Api != null
                ? ControllerState.LoadSuccess
                : ControllerState.LoadFail
            : ControllerState.NotLoaded;

    public struct InitOptions
    {
        internal bool LoadApi = true;
        public ApiVersions MinimumRequired = ApiVersions.V1_0_0;
        public string[] SearchPaths = DefaultSearchPaths;

        /// The RenderDoc overlay ("F12 to capture" etc) is visible by default. Disable it here.
        public bool ShowOverlay = true;

        public InitOptions() { }

        /// This will install the RenderDoc hooks only if `--RenderDoc` is found in command-line arguments.
        public InitOptions(string[] commandLineArgs)
        {
            LoadApi = commandLineArgs.Contains("--RenderDoc", StringComparer.OrdinalIgnoreCase);
        }
    }

    /// <inheritdoc cref="LoadApi"/>
    public static bool Initialize() => Initialize(new InitOptions());

    /// <inheritdoc cref="LoadApi"/>
    public static bool Initialize(InitOptions options)
    {
        if (!options.LoadApi)
            return false;

        if (!LoadApi(options.MinimumRequired, options.SearchPaths))
            return false;

        if (!options.ShowOverlay)
            OverlayBits &= ~OverlayBits.Enabled;
        return true;
    }

    #endregion

    #region loading

    /// True if we tried to load the API, even if loading was unsuccessful.
    public static bool ApiLoaded { get; private set; }

    private static RenderDocApi* Api;

    /// True if the API was loaded successfully through <see cref="LoadApi"/>.
    public static bool IsAvailable => Api != null;

    static readonly string[] DefaultSearchPaths =
    [
        //"renderdoc.dll", // TODO: copying the dll to the app's working directory does load it, but the connection to the actual replay UI doesn't work...
        @"C:\Program Files\RenderDoc\renderdoc.dll",
    ];

    /// <summary>
    /// Try to load the API (= load the in-app API from a native DLL), if it hasn't been loaded already,
    /// and install the RenderDoc hooks.
    /// Note that RenderDoc hooks might incur a performance hit, and interfere with the rendering stack
    /// (Vulkan validation layers etc.), so be sure to only do it in Debug mode.
    ///
    /// Do this as early as possible in the app lifecycle so that RenderDoc can capture resource initialization etc.
    /// Otherwise, loading on-demand later in the app lifecycle may appear to work (RenderDoc will attach),
    /// but capturing may fail, at least not without recreating the Vulkan instance/device etc.
    ///
    /// Once loaded, there may be no going back, ie no detaching without restarting the app
    /// (<a href="https://renderdoc.org/docs/in_application_api.html#_CPPv411RemoveHooksv">RemoveHooks is not guaranteed to work</a>).
    ///
    /// Loading may fail if the DLL isn't found / RenderDoc not installed.
    /// - If the process was started from RenderDoc already, it will be found in the loaded process modules.
    /// - Otherwise, we will look in C:\Program Files\RenderDoc\renderdoc.dll.
    /// - Alternatively, you can provide your own search paths.
    /// </summary>
    /// <param name="minimumRequired">Minimum required RenderDoc API version.</param>
    /// <param name="customSearchPaths">Optional: override the file paths to load the library from.</param>
    /// <returns></returns>
    public static bool LoadApi(
        ApiVersions minimumRequired = ApiVersions.V1_0_0,
        params ReadOnlySpan<string> customSearchPaths
    )
    {
        if (ApiLoaded)
            return IsAvailable;

        lock (typeof(RenderDoc))
        {
            // Prevent double loads.
            if (ApiLoaded)
                return IsAvailable;

            ApiLoaded = true;
            var searchPaths = !customSearchPaths.IsEmpty ? customSearchPaths : DefaultSearchPaths;
            if (!TryLoadApi(searchPaths, minimumRequired, out Api))
            {
                Version = UnknownVersion;
                Log.Debug("RenderDoc: couldn't load API");
                return false;
            }

            GetApiVersion(out var major, out var minor, out var patch);
            Version = new(major, minor, patch);
            Log.Debug($"RenderDoc: API loaded successfully, version: {Version}");
            return true;
        }
    }

    [Pure]
    static bool TryLoadApi(
        ReadOnlySpan<string> searchPaths,
        ApiVersions minimumRequired,
        [NotNullWhen(true)] out RenderDocApi* api
    )
    {
        var re = new Regex(
            @"(lib)?renderdoc(\.dll|\.so|\.dylib)(\.\d+)?",
            RegexOptions.CultureInvariant | RegexOptions.IgnoreCase
        );

        foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
        {
            var path = module.FileName;
            if (path.Contains("Brutal"))
                continue;
            if (!re.IsMatch(path))
                continue;
            if (TryLoadApi(path, minimumRequired, out api))
                return true;
        }

        foreach (var path in searchPaths)
        {
            if (TryLoadApi(path, minimumRequired, out api))
                return true;
        }

        api = null;
        return false;
    }

    [Pure]
    static bool TryLoadApi(string libPath, ApiVersions minimumRequired, [NotNullWhen(true)] out RenderDocApi* api)
    {
        api = null;

        if (!NativeLibrary.TryLoad(libPath, out var libHandle))
            return false;

        if (!NativeLibrary.TryGetExport(libHandle, "RENDERDOC_GetAPI", out var getApiPtr))
            return false;

        Log.Trace($"RenderDoc: API found in {libPath}");

        var getApi = (delegate* unmanaged[Cdecl]<ApiVersions, RenderDocApi**, int>)getApiPtr;
        fixed (RenderDocApi** api_fixed = &api)
        {
            if (getApi(minimumRequired, api_fixed) == 0)
            {
                Log.Error($"RenderDoc: failed to load API from {libPath}");
                return false;
            }
        }

        Debug.Assert(api != null);
        return true;
    }

    #endregion

    #region API version stuff

    static readonly ApiVersion UnknownVersion = new(-1, -1, -1);

    /// Get the RenderDoc version, if loaded successfully, -1 otherwise.
    public static ApiVersion Version { get; private set; } = UnknownVersion;

    /// Whether to check API version on each call.
    public static bool VersionCheckEnabled = true;

    /// Ensure the given API is available in the loaded version.
    static void EnsureApiVersion(int major, int minor, int patch = 0, [CallerMemberName] string apiName = "")
    {
        if (!VersionCheckEnabled)
            return;

        var apiVersion = new ApiVersion(major, minor, patch);
        if (Version < apiVersion)
            throw new NotSupportedException(
                $"API <{apiName}> requires RenderDoc version {apiVersion}, current version is {Version}."
            );
    }

    #endregion

    public static partial void RemoveHooks()
    {
        if (ApiLoaded && Api != null)
            Api->RemoveHooks();
        ApiLoaded = false;
        Api = null;
        Version = UnknownVersion;
    }

    public static bool TryGetCapture(int index, [NotNullWhen(true)] out String8? path, out DateTime time)
    {
        ulong timestamp;
        if (!GetCapture((uint)index, null, out var pathlength, out timestamp))
        {
            path = null;
            time = default;
            return false;
        }

        Span<byte> pathSpan = stackalloc byte[(int)pathlength - 1]; // -1 because pathlength includes the null-terminator
        if (!GetCapture((uint)index, pathSpan, out _, out _))
        {
            path = null;
            time = default;
            return false;
        }

        path = new String8(pathSpan);
        time = DateTimeOffset.FromUnixTimeSeconds((long)timestamp).DateTime;
        return true;
    }

    public static bool GetCaptureOptionBool(CaptureOption opt) => Api->GetCaptureOptionU32(opt) != 0;

    public static void SetCaptureOption(CaptureOption opt, bool value) =>
        Api->SetCaptureOptionU32(opt, value ? 1u : 0u);
}

/// <inheritdoc cref="ApiVersions" />
public readonly record struct ApiVersion(int Major, int Minor, int Patch)
    : IComparable<ApiVersion>,
        IUtf8SpanFormattable,
        ISpanFormattable
{
    /// Version number, packed in the same format as RenderDoc.
    readonly int _packed = Major * 10000 + Minor * 100 + Patch;

    #region IComparable + operators

    public int CompareTo(ApiVersion other) => _packed.CompareTo(other._packed);

    public static bool operator <(ApiVersion left, ApiVersion right) => left._packed < right._packed;

    public static bool operator >(ApiVersion left, ApiVersion right) => left._packed > right._packed;

    public static bool operator <=(ApiVersion left, ApiVersion right) => left._packed <= right._packed;

    public static bool operator >=(ApiVersion left, ApiVersion right) => left._packed >= right._packed;

    #endregion

    #region IUtf8SpanFormattable, ISpanFormattable, IFormattable

    /// IUtf8SpanFormattable implementation
    public bool TryFormat(
        Span<byte> utf8Destination,
        out int bytesWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    )
    {
        return Utf8.TryWrite(utf8Destination, $"{Major}.{Minor}.{Patch}", out bytesWritten);
    }

    /// ISpanFormattable implementation
    public bool TryFormat(
        Span<char> utf16Destination,
        out int charsWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    )
    {
        return utf16Destination.TryWrite($"{Major}.{Minor}.{Patch}", out charsWritten);
    }

    /// IFormattable implementation - useless but required for ISpanFormattable
    string IFormattable.ToString(string? format, IFormatProvider? formatProvider) => ToString();

    public override string ToString() => $"{Major}.{Minor}.{Patch}";

    #endregion
}

/// Specify which RenderDoc version this API is available from, for documentation / tooling.
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class ApiVersionAttribute(int major, int minor, int patch = 0) : Attribute
{
    public readonly ApiVersion MinVersion = new(major, minor, patch);
}
