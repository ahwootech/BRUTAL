using System.Text.RegularExpressions;

namespace Brutal.Localization;

/// <summary>
/// The default values used by various parts of Brutal.Localization.
/// </summary>
public static partial class DefaultOptions
{
    private const string RegexExpression = @"([{]_*\p{Lu}[\p{Lu}\p{Ll}_\d]*[}])";

    /// <summary>
    /// The Regex pattern to use to match replacement variables in localizable strings. If you wish to use a different pattern
    /// set this field before creating <see cref="LString" /> instances.
    /// </summary>
    [GeneratedRegex(RegexExpression, RegexOptions.IgnoreCase, "en-US")]
    public static partial Regex ReplacementPattern();

    /// <summary>
    /// The initial span length that any of the <see cref="LString.Format{TWriter}(TWriter)" /> methods will request from the <see cref="FixedBuffers.IFixedBufferWriter&lt;T&gt;" />.
    /// For more information on how this value is used see <see cref="LString.Format{TWriter}(TWriter)" />.
    /// </summary>
    public static readonly ElementCount FormatInitialSpanLength = 256;
}
