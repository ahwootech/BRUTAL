// The internal half of the EFX surface (public half: Efx.cs): the checked creation helpers behind
// the generated typed Create* methods, plus the current-context guard they share.

using static Brutal.OpenAlApi.Al.Constants;

namespace Brutal.OpenAlApi;

public sealed partial class Efx
{
    // --- Checked creation ------------------------------------------------------------------------
    //
    // Creating a typed effect or filter is a two-step native transaction: generate, then assign
    // the type. The sticky AL error latch is drained BEFORE the sequence (so an unrelated earlier
    // failure is not reported as this call's), and the half-built object is deleted if the type
    // assignment fails - the raw name never escapes, so an abandoned one would be an unreachable
    // leak.

    // An Efx belongs to its Device, but the AL calls route through the process-global current
    // context; without this check, creation would silently land on whichever device's context is
    // current. alcGetContextsDevice is used rather than Context.Current so contexts created via
    // raw interop resolve the same way.
    private void ThrowIfNotCurrentOnDevice()
    {
        Device.ThrowIfDisposed();
        var device = Device.Handle;
        var current = Alc.PInvoke.GetCurrentContext();
        if (current.IsNull())
        {
            throw new InvalidOperationException(
                "No AL context is current. EFX objects are created on the current context; make a "
                    + "context on this Efx instance's device current first."
            );
        }

        if (Alc.PInvoke.GetContextsDevice(current).Pointer != device.Pointer)
        {
            throw new InvalidOperationException(
                "The current AL context belongs to a different device than this Efx instance, which "
                    + "belongs to the device it was obtained from. Make a context on that device "
                    + "current, or use the Efx of the device you are actually using."
            );
        }
    }

    internal AlEffect CreateEffectChecked(int type)
    {
        ThrowIfNotCurrentOnDevice();
        Al.GetError();
        var effect = GenEffect();
        Al.PInvoke.Effecti(effect.Name, AL_EFFECT_TYPE, type);
        try
        {
            Al.ThrowIfError();
        }
        catch
        {
            Rollback(effect);
            throw;
        }
        return effect;
    }

    internal AlFilter CreateFilterChecked(int type)
    {
        ThrowIfNotCurrentOnDevice();
        Al.GetError();
        var filter = GenFilter();
        Al.PInvoke.Filteri(filter.Name, AL_FILTER_TYPE, type);
        try
        {
            Al.ThrowIfError();
        }
        catch
        {
            Rollback(filter);
            throw;
        }
        return filter;
    }

    // Single-step, so nothing to roll back - but the stale-latch drain still applies.
    internal AlAuxiliaryEffectSlot CreateSlotChecked()
    {
        ThrowIfNotCurrentOnDevice();
        Al.GetError();
        var slot = GenAuxiliaryEffectSlot();
        Al.ThrowIfError();
        return slot;
    }

    // Undoes the generate step of a failed creation; a null name means generation itself failed.
    // The trailing drain discards any secondary error the cleanup delete latches.
    private void Rollback(AlEffect effect)
    {
        if (effect.IsNull())
            return;
        DeleteEffects([effect]);
        Al.GetError();
    }

    private void Rollback(AlFilter filter)
    {
        if (filter.IsNull())
            return;
        DeleteFilters([filter]);
        Al.GetError();
    }
}
