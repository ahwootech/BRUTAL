// The EFX surface. The pinned openal-soft always implements ALC_EXT_EFX, so there is no presence
// gate. EFX entry points bind statically in Al.PInvoke like core ones (see Extensions.cs). The
// Gen*/Delete* and typed Create* methods are generated, the latter over the checked creation
// helpers in Efx.Internal.cs.

namespace Brutal.OpenAlApi;

/// <summary>
///     The EFX extension surface: effect, filter and auxiliary-effect-slot creation, plus the EFX
///     device queries.
/// </summary>
/// <remarks>
///     Obtained from <see cref="Device.Efx"/>. The typed create methods (for example
///     <c>CreateReverb</c>) fix the object's type at creation and return a typed wrapper; the
///     <c>Gen*</c> methods create raw, untyped objects for lower-level use. Deletion lives on the
///     handles themselves (<see cref="AlEffect.Delete"/> etc.) or in bulk via the generated
///     <c>Delete*</c> span methods.
///     <para>
///         The typed create methods require a context on this instance's device to be current, and
///         throw <see cref="InvalidOperationException"/> otherwise. An <see cref="Efx"/> belongs to
///         the <see cref="Device"/> it was obtained from, but the underlying AL calls route through
///         the process-global current context, so the two have to agree - otherwise the objects are
///         created on whichever device happens to be current instead. The lower-level <c>Gen*</c>
///         methods do not check, matching the raw AL behaviour.
///     </para>
/// </remarks>
public sealed partial class Efx
{
    internal Device Device { get; }

    internal Efx(Device device) => Device = device;

    // Lifetime-constant queries, cached on first access. The versions are fixed by the loaded
    // implementation; the send count is renegotiable via Device.Reset/Reopen, which call
    // InvalidateDeviceCaches below.
    //
    // Named fields, not the property-backing 'field' keyword: 'field' is typed as the property (an
    // int property can't take ??=) and is unreachable outside its own accessors (so an externally
    // invalidated cache couldn't be reset). Every cache in this package is written this way.
    private int? _efxMajorVersion;
    private int? _efxMinorVersion;
    private int? _maxAuxiliarySends;

    internal void InvalidateDeviceCaches() => _maxAuxiliarySends = null;

    /// <summary>The EFX major version (<c>ALC_EFX_MAJOR_VERSION</c>).</summary>
    public int EfxMajorVersion
    {
        get
        {
            Device.ThrowIfDisposed();
            var device = Device.Handle;
            return _efxMajorVersion ??= Alc.GetInteger(device, AlcInteger.EfxMajorVersion);
        }
    }

    /// <summary>The EFX minor version (<c>ALC_EFX_MINOR_VERSION</c>).</summary>
    public int EfxMinorVersion
    {
        get
        {
            Device.ThrowIfDisposed();
            var device = Device.Handle;
            return _efxMinorVersion ??= Alc.GetInteger(device, AlcInteger.EfxMinorVersion);
        }
    }

    /// <summary>
    ///     The number of auxiliary sends per source (<c>ALC_MAX_AUXILIARY_SENDS</c>). Cached;
    ///     <see cref="Device.Reset"/> and <see cref="Device.Reopen"/> (which can renegotiate it)
    ///     drop the cache.
    /// </summary>
    public int MaxAuxiliarySends
    {
        get
        {
            Device.ThrowIfDisposed();
            var device = Device.Handle;
            return _maxAuxiliarySends ??= Alc.GetInteger(device, AlcInteger.MaxAuxiliarySends);
        }
    }
}
