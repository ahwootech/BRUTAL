namespace Brutal.Logging;

/// <summary>
/// A default log category to use when no other is specified
/// </summary>
/// <example>
/// The following code demonstrates how to import the default logger globally:
/// <code>
/// global using static Brutal.Logging.DefaultCategory;
/// </code>
/// </example>
public static class DefaultCategory
{
    /// <summary>
    /// A default log category
    /// </summary>
    public static readonly LogCategory Log = LogCategory.Make("Default");
}
