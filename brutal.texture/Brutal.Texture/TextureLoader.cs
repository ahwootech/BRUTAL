using Brutal.TextureApi.Gli;
using Brutal.TextureApi.Ktx;
using Brutal.TextureApi.Stb;

namespace Brutal.TextureApi;

/// <summary>
/// A class for loading and unloading textures. Supports the following formats:
/// <para />bmp, dds, gif, hdr, jpg (both .jpg and .jpeg), kmg, ktx, ktx2, pgm, pic, png, ppm, psd, tga
/// <para />Note: gif, pgm, pic, ppm and psd are load-only - stb can decode them but cannot encode them, so they cannot be saved.
/// </summary>
public static partial class TextureLoader
{
    public enum FormatType
    {
        Bmp,
        Dds,
        Gif,
        Hdr,
        Jpg,
        Kmg,
        Ktx,
        Ktx2,
        Pgm,
        Pic,
        Png,
        Ppm,
        Psd,
        Tga,
    }

    static TextureLoader()
    {
        // Extensions are matched case-insensitively: LoadFromFile normalises via ToLowerInvariant
        // and ExtensionToFormat uses OrdinalIgnoreCase, so "Foo.PNG" resolves the same as "foo.png".
        ExtensionToFormat = new(StringComparer.OrdinalIgnoreCase);
        FormatToExtension = new();
        Diagnostics = new();
        InitialiseLookupDictionaries();
    }

    /// <summary>
    /// Load a texture from a file on disk.
    /// </summary>
    /// <param name="filePath">Path to the file</param>
    /// <param name="settings">Collection of options settings for various formats</param>
    /// <returns>The ITexture representing of the loaded image file</returns>
    /// <exception cref="NotSupportedException">Thrown if the extension is unsupported</exception>
    public static ITexture LoadFromFile(string filePath, params TextureLoadSettings?[] settings)
    {
        ITexture texture;

        var extension = Path.GetExtension(filePath).ToLowerInvariant();

        if (Ktx.Loader.SupportedExtensions.Contains(extension))
            texture = Ktx.Loader.LoadFromFile(
                filePath,
                settings.FirstOrDefault(s => s is Ktx.Loader.LoadSettings) as Ktx.Loader.LoadSettings
            );
        else if (Stb.Loader.SupportedExtensions.Contains(extension))
            texture = Stb.Loader.LoadFromFile(
                filePath,
                settings.FirstOrDefault(s => s is Stb.Loader.LoadSettings) as Stb.Loader.LoadSettings
            );
        else if (Gli.Loader.SupportedExtensions.Contains(extension))
            texture = Gli.Loader.LoadFromFile(filePath);
        else
            throw new NotSupportedException($"No loader found that supports file {extension}");

        RecordLoadedTexture(texture);

        return texture;
    }

    /// <summary>
    /// Load a texture from memory. The format of the data in memory must be the same as if the
    /// texture was written to memory with TextureSaver.SaveToMemory
    /// </summary>
    /// <param name="data">Span of the texture's bytes</param>
    /// <param name="formatType">The source image format of the texture memory</param>
    /// <param name="settings">Collection of options settings for various formats</param>
    /// <returns>The ITexture representing of the loaded image file</returns>
    /// <exception cref="NotSupportedException">Thrown if the extension is unsupported</exception>
    public static ITexture LoadFromMemory(
        ReadOnlySpan<byte> data,
        FormatType formatType,
        params TextureLoadSettings?[] settings
    )
    {
        ITexture texture;
        var extension = FormatToExtension[formatType];

        if (Ktx.Loader.SupportedExtensions.Contains(extension))
            texture = Ktx.Loader.LoadFromMemory(
                data,
                settings.FirstOrDefault(s => s is Ktx.Loader.LoadSettings) as Ktx.Loader.LoadSettings
            );
        else if (Stb.Loader.SupportedExtensions.Contains(extension))
            texture = Stb.Loader.LoadFromMemory(
                data,
                settings.FirstOrDefault(s => s is Stb.Loader.LoadSettings) as Stb.Loader.LoadSettings
            );
        else if (Gli.Loader.SupportedExtensions.Contains(extension))
            texture = Gli.Loader.LoadFromMemory(data);
        else
            throw new NotSupportedException($"No loader found that supports file {extension}");

        RecordLoadedTexture(texture);

        return texture;
    }

    /// <summary>
    /// Unload a texture that was loaded with TextureLoader.
    /// Also untracks the texture instance if tracking is enabled.
    /// </summary>
    /// <param name="texture">The ITexture to unload</param>
    /// <exception cref="ArgumentException">Thrown if texture was not loaded by this TextureLoader</exception>
    public static void Unload(ITexture texture)
    {
        switch (texture)
        {
            case KtxTexture ktxTexture:
                RecordUnloadedTexture(texture);
                ktxTexture.Destroy();
                return;
            case StbTexture stbTexture:
                RecordUnloadedTexture(texture);
                stbTexture.Destroy();
                return;
            case GliTexture gliTexture:
                RecordUnloadedTexture(texture);
                gliTexture.Destroy();
                return;
        }

        throw new ArgumentException(
            $"Cannot unload a texture that was not loaded by TextureLoader. texture: {texture}"
        );
    }

    public static LoadDiagnostics Diagnostics { get; }

    /// <summary>
    /// The total number of textures this TextureLoader has ever loaded.
    /// </summary>
    public static ulong TotalLoadedCount => Interlocked.Read(ref _totalLoadedCount);

    /// <summary>
    /// The number of textures currently still loaded by this TextureLoader
    /// </summary>
    public static ulong CurrentLoadedCount => Interlocked.Read(ref _currentLoadedCount);

    /// <summary>
    /// Returns whether a specified file path or extension is supported by TextureLoader.
    /// </summary>
    /// <param name="pathOrExtension">The extension or file path to test. If testing an extension then it must include the '.' prefix</param>
    /// <returns>true if the file or extension is suported, otherwise false</returns>
    public static bool IsSupported(string pathOrExtension) => TryGetFormatType(pathOrExtension, out _);

    /// <summary>
    /// Returns the FormatType that corresponds to a file path or extension.
    /// </summary>
    /// <param name="pathOrExtension">The file path or extension to get the FormatType of. <para />If an extension is passed in to this function, it must include the '.' prefix.</param>
    /// <param name="formatType">The out parameter filled with the FormatType. This value is undefined if a FormatType cannot be found.</param>
    /// <returns>true if a supported format, otherwise false. Will return false for an empty pathOrExtension.</returns>
    public static bool TryGetFormatType(string pathOrExtension, out FormatType formatType)
    {
        formatType = FormatType.Png;
        if (pathOrExtension.Length == 0)
            return false;

        return ExtensionToFormat.TryGetValue(Path.GetExtension(pathOrExtension), out formatType);
    }

    /// <summary>
    /// Convert a file extension or file path to a <see cref="TextureLoader.FormatType" /> or throws an exception if the extension
    /// is not supported.
    /// </summary>
    /// <param name="pathOrExtension">The file path or extension to test. <para />If an extension is passed in to this function, it must include the '.' prefix.</param>
    /// <returns><see cref="FormatType"/> if a supported format, otherwise throws.</returns>
    /// <exception cref="ArgumentException">Thrown if pathOrExtension is empty, null or not a supported extension.</exception>
    public static FormatType GetFormatType(string pathOrExtension)
    {
        if (pathOrExtension is null || pathOrExtension.Length == 0)
            throw new ArgumentException($"null or empty extension");

        if (!ExtensionToFormat!.TryGetValue(Path.GetExtension(pathOrExtension), out var format))
            throw new ArgumentException($"'{pathOrExtension}' is not a supported format");

        return format;
    }

    /// <summary>
    /// Holds trace information about a loaded texture. Currently this includes a
    /// reference to the ITexture and a prettified set of stacktrace strings from when an ITexture was
    /// loaded. See <see cref="LoadDiagnostics.GetCurrentTracedLoads" /> for more information.
    /// </summary>
    public struct LoadTrace
    {
        public ITexture Instance;
        public IList<string> FriendlyStackTrace;
    }

    /// <summary>
    /// Class that holds diagnostic information about the loading of textures.
    /// </summary>
    public class LoadDiagnostics
    {
        public LoadDiagnostics()
        {
            _isTracingEnabled = false;
            _resourceTracker = new ResourceTracker<ITexture>();
        }

        /// <summary>
        /// Sets whether the texture system should trace the source of texture loads.
        /// <para />
        /// Client code can call <see cref="GetCurrentTracedLoads" /> to get the tracing information
        /// of all textures that are currently loaded.
        /// </summary>
        /// <param name="enableTracking">If true, tracing is enabled. Otherwise tracing is disabled.</param>
        public void EnableLoadTracing(bool enableTracking)
        {
            _isTracingEnabled = enableTracking;
            if (!_isTracingEnabled)
                _resourceTracker.Reset();
        }

        /// <summary>
        /// Returns a collection of instantiation information for currently loaded textures.
        /// <para />
        /// The FriendlyStackTrace field will contain a collection of strings, one for each
        /// StackFrame in the callstack at the time the texture was loaded. StackFrames from Brutal, Microsoft or System namespaces will be removed.
        /// <para />
        /// The strings contain method name, file name and line number.
        /// <para />
        /// This function processes StackFrame objects and builds strings, therefore should not be called
        /// during a hot-path.
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<LoadTrace> GetCurrentTracedLoads(
            int stackFrameCount = DefaultFriendlyStackFrameCount
        )
        {
            return _resourceTracker
                .CurrentResources()
                .Select(entry => new LoadTrace
                {
                    Instance = entry.Instance,
                    FriendlyStackTrace = StackTraceFormatting.FriendlyStackTraceStrings(
                        entry.StackTrace,
                        stackFrameCount
                    ),
                })
                .ToArray();
        }

        internal void Track(ITexture texture)
        {
            if (_isTracingEnabled)
                _resourceTracker.Track(texture);
        }

        internal void Untrack(ITexture texture)
        {
            if (_isTracingEnabled)
                _resourceTracker.Untrack(texture);
        }

        private bool _isTracingEnabled;
        private readonly ResourceTracker<ITexture> _resourceTracker;
    }

    #region Private

    private static void RecordLoadedTexture(ITexture texture)
    {
        Interlocked.Increment(ref _currentLoadedCount);
        Interlocked.Increment(ref _totalLoadedCount);
        Diagnostics.Track(texture);
    }

    private static void RecordUnloadedTexture(ITexture texture)
    {
        Interlocked.Decrement(ref _currentLoadedCount);
        Diagnostics.Untrack(texture);
    }

    private static void InitialiseLookupDictionaries()
    {
        var formatNames = Enum.GetNames<FormatType>();
        var formatValues = Enum.GetValues<FormatType>();
        for (var index = 0; index < formatNames.Length; ++index)
        {
            var extension = $".{formatNames[index].ToLowerInvariant()}";
            ExtensionToFormat[extension] = formatValues[index];
            FormatToExtension[formatValues[index]] = extension;
        }

        ExtensionToFormat[".jpeg"] = FormatType.Jpg;
    }

    private const int DefaultFriendlyStackFrameCount = 5;
    private static readonly Dictionary<string, FormatType> ExtensionToFormat;
    private static readonly Dictionary<FormatType, string> FormatToExtension;
    private static ulong _totalLoadedCount;
    private static ulong _currentLoadedCount;

    #endregion
}
