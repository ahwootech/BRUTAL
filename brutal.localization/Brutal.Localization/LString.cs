using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Brutal.Localization;

/// <summary>
/// A class that represents a localizable string.
/// </summary>
public partial class LString
{
    /// <summary>
    /// Create a localizable string from a template string. The format of the template will depend on the Regex assigned
    /// to ReplacementPattern.
    /// Upon creation the LString is NOT localized. Therefore, calling any of the
    /// <see cref="Format"/> methods before it has been localized will return the templateString.
    /// </summary>
    /// <param name="id">An immutable, unique id that identifies this LString.</param>
    /// <param name="templateString">The string to use as a template for the localized string. Can be empty.</param>
    /// <param name="replacementPattern">The Regex to use to match replacement variables. If null, uses <see cref="DefaultOptions.ReplacementPattern" /></param>
    public LString(LStringId id, string templateString, Regex? replacementPattern = null)
    {
        Id = id;
        _replacements = new List<Replacement>(MaxReplacementCount);
        _templateString = templateString;
        _replacementPattern = replacementPattern ?? DefaultOptions.ReplacementPattern();
        _localizedString = templateString;
        BuildReplacements(true);
    }

    /// <inheritdoc cref="LString(LStringId,string,System.Text.RegularExpressions.Regex?)"/>
    /// <exception cref="ArgumentException">Thrown if id is null or empty.</exception>
    public LString(string id, string templateString, Regex? replacementPattern = null)
        : this(LStringId.From(id), templateString, replacementPattern) { }

    /// <summary>
    /// Returns the unique id of the LString.
    /// </summary>
    public LStringId Id { get; }

    /// <summary>
    /// Returns the string used as the template string when creating this instance
    /// of LString.
    /// </summary>
    public string Template => _templateString;

    /// <summary>
    /// Returns the current localized string for this LString or returns Template if this LString has not been localized yet.
    /// </summary>
    public string Localized => _localizedString;

    /// <summary>
    /// Localizes the LString with specified content.
    /// localizedString is validated to ensure it meets the criteria of the template string.
    /// e.g., it must have the same number and names of replacement variables.
    /// </summary>
    /// <param name="localizedString">The localized version of the template string</param>
    /// <exception cref="ArgumentException">Thrown if localizedString does not have the correct number and names of replacement variables.</exception>
    /// <exception cref="ArgumentNullException">Thrown if localizedString is null.</exception>
    public void Localize(string localizedString)
    {
        Update(localizedString);
    }

    /// <summary>
    /// Clears the localized version of the string, thereby returning it
    /// to its template string.
    /// </summary>
    public void RemoveLocalization()
    {
        Update(_templateString);
    }

    /// <summary>
    /// Returns the Regex used by this LString to match replacement variables.
    /// </summary>
    public Regex ReplacementPattern => _replacementPattern;

    #region Private

    [MemberNotNull(nameof(_localizedString))]
    private void Update(string localizedString)
    {
        _localizedString =
            localizedString ?? throw new ArgumentNullException(nameof(localizedString));
        BuildReplacements(false);
    }

    private void BuildReplacements(bool isInitialBuild)
    {
        _literalCharCount = 0;
        _endLiteralStart = 0;
        var matches = _replacementPattern.EnumerateMatches(_localizedString);
        var nextPossibleLiteralStart = 0;
        ushort replacementCount = 0;
        foreach (var match in matches)
        {
            if (!isInitialBuild && replacementCount >= _replacements.Count)
                throw IncorrectReplacementCountException(Template, _localizedString);

            var matchPos = match.Index;
            var templateReplacementIndex = isInitialBuild
                ? replacementCount
                : GetTemplateStringReplacementIndex(
                    _localizedString.AsSpan()[matchPos..(matchPos + match.Length)]
                );

            _literalCharCount += matchPos - nextPossibleLiteralStart;
            var replacementRange = new Range(matchPos, matchPos + match.Length);
            var literalRange =
                matchPos > nextPossibleLiteralStart
                    ? new Range(nextPossibleLiteralStart, matchPos)
                    : default;

            if (isInitialBuild)
                _replacements.Add(
                    new Replacement()
                    {
                        TemplateRange = replacementRange,
                        LiteralRange = literalRange,
                        TemplateReplacementIndex = templateReplacementIndex,
                    }
                );
            else
                _replacements[replacementCount] = _replacements[replacementCount] with
                {
                    LiteralRange = literalRange,
                    TemplateReplacementIndex = templateReplacementIndex,
                };

            nextPossibleLiteralStart = replacementRange.End.Value;
            ++replacementCount;
        }

        if (!isInitialBuild && replacementCount != _replacements.Count)
            throw IncorrectReplacementCountException(Template, _localizedString);

        _endLiteralStart =
            nextPossibleLiteralStart == 0 ? _localizedString.Length : nextPossibleLiteralStart;
    }

    private ushort GetTemplateStringReplacementIndex(ReadOnlySpan<char> replacementText)
    {
        for (
            ushort existingReplacementIndex = 0;
            existingReplacementIndex < _replacements.Count;
            ++existingReplacementIndex
        )
        {
            var templateReplacement = Template.AsSpan()[
                _replacements[existingReplacementIndex].TemplateRange
            ];
            if (templateReplacement.SequenceEqual(replacementText))
                return existingReplacementIndex;
        }
        throw UnknownReplacementVariableException(Template, replacementText);
    }

    private static ArgumentException UnknownReplacementVariableException(
        string template,
        ReadOnlySpan<char> replacementText
    )
    {
        return new ArgumentException(
            $"Unknown replacement variable: {replacementText}. Did not exist in LString {template}"
        );
    }

    private static Exception IncorrectReplacementCountException(
        string template,
        string localizedString
    )
    {
        return new ArgumentException(
            $"Incorrect replacement count for localized string {localizedString}. Template was {template}"
        );
    }

    private readonly struct Replacement
    {
        /// <summary>
        /// Original Range within the template string of this Replacement. Retrieve the template string with
        /// the <see cref="Template"/> property.
        /// </summary>
        public required Range TemplateRange { get; init; }

        /// <summary>
        /// The index of the replacement inside the original Template string.
        /// </summary>
        public required ushort TemplateReplacementIndex { get; init; }

        /// <summary>
        /// Returns whether this replacement has a preceding literal.
        /// </summary>
        public bool HasPrecedingLiteral => LiteralRange.End.Value > LiteralRange.Start.Value;
        public required Range LiteralRange { get; init; } // The range of any literal preceding this Replacement
    }

    private readonly string _templateString; // The original template string
    private string _localizedString; // localized template string

    private readonly List<Replacement> _replacements;
    private int _endLiteralStart; // if _endLiteralStart < length of _localizedString, there's a literal past the last replacement (Or _localizedString only a literal)
    private int _literalCharCount; // How many literal characters in the localized string? The interpolated string handlers need this.

    private readonly Regex _replacementPattern;
    #endregion
}
