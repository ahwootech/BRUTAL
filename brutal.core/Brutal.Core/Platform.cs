namespace Brutal;

/// <summary>
/// Utility class to determine the current platform
/// </summary>
public static class Platform
{
    /// <summary> Enum representing supported platform families /// </summary>
    public enum Family
    {
        Windows,
        Linux,
        MacOS,
    }

    /// <summary>The current runtime platform</summary>
    public static readonly Family CurrentFamily;

    public static bool IsWindows => CurrentFamily == Family.Windows;
    public static bool IsLinux => CurrentFamily == Family.Linux;
    public static bool IsMacOS => CurrentFamily == Family.MacOS;
    public static bool IsUnix => CurrentFamily.IsUnix();

    static Platform()
    {
        if (OperatingSystem.IsWindows())
            CurrentFamily = Family.Windows;
        else if (OperatingSystem.IsLinux())
            CurrentFamily = Family.Linux;
        else if (OperatingSystem.IsMacOS())
            CurrentFamily = Family.MacOS;
        else
            throw new PlatformNotSupportedException("Unsupported platform");
    }
}

public static class PlatformFamilyExtensions
{
    /// <summary>
    /// Get the OperatingSystem instance for the given PlatformFamily
    /// </summary>
    public static bool IsUnix(this Platform.Family family)
    {
        return family is Platform.Family.Linux or Platform.Family.MacOS;
    }
}
