using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using Brutal.Logging;

namespace Brutal.Localization;

/// <summary>
/// Class for managing localization of strings via LString instances. You can create multiple instances of
/// LocalizedStrings and each will act without interfering with any other instances.
/// Typically, however, you will use a single static instance which can be used simply by calling the static
/// methods in LStrings. The LStrings methods all simply redirect to a shared instance of LocalizedStrings.
/// </summary>
public class LocalizedStrings
{
    /// <summary>
    /// A delegate that takes a <see cref="LString" /> and return a localized version of that LString's template string.
    /// In typical use, this delegate acts as a language provider.
    /// Your implementation of <see cref="GetLocalizedStringDelegate"/>  must set localizedTemplateString to a non-null
    /// string if you return true (Indicating that a string was found).
    /// </summary>
    /// <param name="lString">The LString whose localized string has been requested.</param>
    /// <param name="localizedTemplateString">The out variable that is set if this method returns true.</param>
    /// <returns>true if the delegate found and returned a string. Otherwise, false.</returns>
    public delegate bool GetLocalizedStringDelegate(
        LString lString,
        [NotNullWhen(true)] out string? localizedTemplateString
    );

    /// <summary>
    /// Construct a new instance of LocalizedStrings. Each instance is its own string localization environment.
    /// </summary>
    /// <param name="replacementPattern">The Regex to use to match replacement variables in LStrings created by this LocalizedStrings instance. If null, uses <see cref="DefaultOptions.ReplacementPattern" /></param>
    public LocalizedStrings(Regex? replacementPattern = null)
    {
        _lStringProvider = null;
        _stringInstances = new();
        _replacementPattern = replacementPattern ?? DefaultOptions.ReplacementPattern();
    }

    /// <summary>
    /// Set the GetLocalizedStringDelegate that the Brutal localization system will use to look up localized strings. This function
    /// will also localize all existing LString instances with the new provider.
    /// <para />
    /// </summary>
    /// <param name="stringProvider">A <see cref="GetLocalizedStringDelegate" /> that the localization system will use to look up strings.</param>
    public void SetLocalizedStringProvider(GetLocalizedStringDelegate stringProvider)
    {
        if (stringProvider is null)
            throw new ArgumentNullException(nameof(stringProvider), @"Null stringProvider");

        lock (_lock)
        {
            _lStringProvider = stringProvider;
            foreach (var (key, lString) in _stringInstances)
            {
                if (!_lStringProvider(lString, out var localizedString))
                {
                    lString.RemoveLocalization();
                    continue;
                }

                lString.Localize(localizedString);
            }
        }
    }

    /// <summary>
    /// Returns the delegate that is currently providing localized versions of LString instances.
    /// </summary>
    /// <returns>The <see cref="GetLocalizedStringDelegate"/> or null if one is not set.</returns>
    public GetLocalizedStringDelegate? LocalizedStringProvider => _lStringProvider;

    /// <summary>
    /// Removes the provider of localized strings. After calling <see cref="RemoveLocalizedStringProvider" />
    /// LString instances will return their template string from calls to Format.
    /// </summary>
    public void RemoveLocalizedStringProvider()
    {
        lock (_lock)
        {
            _lStringProvider = null;
            foreach (var (_, lString) in _stringInstances)
                lString.RemoveLocalization();
        }
    }

    /// <summary>
    /// Instantiates a new, unique LString instance with a template string. If there is a string provider
    /// currently set, the LString will also be localized to the current language.
    /// </summary>
    /// <param name="id">A string representing a unique <see cref="LStringId" /> of the LString to create.</param>
    /// <param name="templateString">The string that defines the non-localized string contents</param>
    /// <returns>The newly created LString.</returns>
    /// <exception cref="ArgumentException">Thrown if a LString with the same id already exists.</exception>
    /// <exception cref="ArgumentNullException">Thrown if templateString is null.</exception>
    public LString Create(string id, string templateString)
    {
        return Create(LStringId.From(id), templateString);
    }

    /// <summary>
    /// Instantiates a new, unique LString instance with a template string. If there is a GetLocalizedStringDelegate
    /// currently set, the LString will also be localized to the current language with a language string with the same id.
    /// </summary>
    /// <param name="id">The unique <see cref="LStringId" /> of the LString to create.</param>
    /// <param name="templateString">The string that defines the non-localized string contents</param>
    /// <returns>The newly created LString.</returns>
    /// <exception cref="ArgumentException">Thrown if a LString with the same id already exists.</exception>
    /// <exception cref="ArgumentNullException">Thrown if templateString is null.</exception>
    public LString Create(LStringId id, string templateString)
    {
        if (templateString is null)
            throw new ArgumentNullException(nameof(templateString), @"Null template string");

        lock (_lock)
        {
            var lString = new LString(id, templateString, _replacementPattern);
            if (!_stringInstances.TryAdd(lString.Id, lString))
                throw new ArgumentException($"Duplicate LString with id {id}");

            if (!HasStringProvider)
                return lString;

            if (!_lStringProvider!(lString, out var localizedString))
            {
                DefaultCategory.Log.Debug($"Missing string with id {lString.Id}");
                return lString;
            }

            lString.Localize(localizedString);
            return lString;
        }
    }

    /// <summary>
    /// Attempts to get a LString with the given id. If it doesn't exist, it will be created and returned.
    /// </summary>
    /// <param name="id">The <see cref="LStringId" /> of the LString to find or create.</param>
    /// <param name="templateString">The templateString to use for the new LString if a new LString is created.</param>
    /// <returns>The LString instance found or created.</returns>
    public LString GetOrCreate(LStringId id, string templateString)
    {
        lock (_lock)
        {
            if (TryGet(id, out var localizedString))
                return localizedString;

            return Create(id, templateString);
        }
    }

    /// <inheritdoc cref="GetOrCreate(LStringId, string)"/>
    public LString GetOrCreate(string id, string templateString)
    {
        return GetOrCreate(LStringId.From(id), templateString);
    }

    /// <summary>
    /// Removes a LString from the set of localized strings.
    /// </summary>
    /// <param name="id">The identifier of the LString to remove.</param>
    /// <returns>true if the LString was successfully removed; otherwise, false.</returns>
    public bool Remove(LStringId id)
    {
        lock (_lock)
        {
            return _stringInstances.Remove(id);
        }
    }

    /// <summary>
    /// Removes all LString instances.
    /// </summary>
    public void RemoveAll()
    {
        lock (_lock)
        {
            _stringInstances.Clear();
        }
    }

    /// <summary>
    /// Attempt to get a LString with the given id and returns whether it was found.
    /// </summary>
    /// <param name="id">The <see cref="LStringId" /> of the LString to get.</param>
    /// <param name="localizedString">The LString that is set, if found. Otherwise undefined.</param>
    /// <returns>True if the LStringId was found. Otherwise, false.</returns>
    public bool TryGet(LStringId id, [NotNullWhen(true)] out LString? localizedString)
    {
        lock (_lock)
        {
            return _stringInstances.TryGetValue(id, out localizedString);
        }
    }

    /// <summary>
    /// Returns an IReadOnlyDictionary of all LString instances created through Brutal.Localization.
    /// Instances of LString created manually (via new()) are not included in here.
    /// <para />
    /// <remarks>This is a lightweight call and does not copy the set of strings. However, the returned reference
    /// is NOT thread-safe. If the underlying collection is modified (e.g., with calls to Create methods of <see cref="LStrings" />) then the underlying collection
    /// will be modified and will generate errors if you are iterating the collection at the time.</remarks>
    /// </summary>
    public IReadOnlyDictionary<LStringId, LString> LStringInstances =>
        _stringInstances.AsReadOnly();

    #region Private
    private bool HasStringProvider => _lStringProvider is not null;

    private GetLocalizedStringDelegate? _lStringProvider;
    private readonly Dictionary<LStringId, LString> _stringInstances;
    private readonly Lock _lock = new();
    private readonly Regex _replacementPattern;

    #endregion
}
