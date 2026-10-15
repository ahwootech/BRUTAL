using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Brutal.Localization;

/// <summary>
/// LStrings is a convenience static wrapper around a singleton-like instance of LocalizedStrings.
/// For use if you don't like typing LocalizedStrings.Shared.Method().
/// Investigation showed that this redirection does not introduce extra jumps and returns.
/// </summary>
// TODO:AKB - Add analyser to check all methods from LocalizedStrings are in here as well. I did add a UnitTest to check for signatures which is a start.
public static class LStrings
{
    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.SetLocalizedStringProvider"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.SetLocalizedStringProvider"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SetLocalizedStringProvider(
        LocalizedStrings.GetLocalizedStringDelegate stringProvider
    ) => Shared.SetLocalizedStringProvider(stringProvider);

    /// <summary>
    /// Returns the delegate that is currently providing localized versions of LString instances.
    /// </summary>
    /// <returns>The <see cref="LocalizedStrings.GetLocalizedStringDelegate"/> or null if one is not set.</returns>
    public static LocalizedStrings.GetLocalizedStringDelegate? LocalizedStringProvider =>
        Shared.LocalizedStringProvider;

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.RemoveLocalizedStringProvider"/>
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RemoveLocalizedStringProvider() => Shared.RemoveLocalizedStringProvider();

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.Create(string, string)"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.Create(string, string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LString Create(string id, string templateString) =>
        Shared.Create(LStringId.From(id), templateString);

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.Create(LStringId, string)"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.Create(LStringId, string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LString Create(LStringId id, string templateString) =>
        Shared.Create(id, templateString);

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.GetOrCreate(LStringId, string)"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.GetOrCreate(LStringId, string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LString GetOrCreate(LStringId id, string templateString) =>
        Shared.GetOrCreate(id, templateString);

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.GetOrCreate(string, string)"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.GetOrCreate(string, string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LString GetOrCreate(string id, string templateString) =>
        Shared.GetOrCreate(LStringId.From(id), templateString);

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.Remove"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.Remove"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Remove(LStringId id) => Shared.Remove(id);

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.RemoveAll"/>
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RemoveAll() => Shared.RemoveAll();

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.TryGet"/>
    /// </summary>
    /// <inheritdoc cref="LocalizedStrings.TryGet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryGet(LStringId id, [NotNullWhen(true)] out LString? localizedString) =>
        Shared.TryGet(id, out localizedString);

    /// <summary>
    /// <inheritdoc cref="LocalizedStrings.LStringInstances"/>
    /// </summary>
    public static IReadOnlyDictionary<LStringId, LString> LStringInstances =>
        Shared.LStringInstances;

    private static readonly LocalizedStrings Shared = new(LStringsOptions.ReplacementPattern);
}
