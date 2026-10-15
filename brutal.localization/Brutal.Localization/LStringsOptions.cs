using System.Text.RegularExpressions;

namespace Brutal.Localization;

/// <summary>
/// Options used by the static wrapper, <see cref="LStrings"/>. Set these options before the first instance of an <see cref="LString"/> is
/// created through with <see cref="LStrings"/>.
/// </summary>
public static class LStringsOptions
{
    /// <summary>
    /// The Regex pattern to use to match replacement variables in localizable strings. If you wish to use a different pattern
    /// set this field before creating <see cref="LString" /> instances.
    /// </summary>
    public static Regex ReplacementPattern = DefaultOptions.ReplacementPattern();
}
