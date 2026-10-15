namespace Brutal.Localization.ResX;

/// <summary>
/// Represents a single &lt;data&gt; tag in a text ResX file.
/// </summary>
/// <param name="Name">Name of the data.</param>
/// <param name="Value">Value of the data.</param>
/// <param name="Comment">Optional comment to go along with the data.</param>
public record ResXData(string Name, string Value, string? Comment);
