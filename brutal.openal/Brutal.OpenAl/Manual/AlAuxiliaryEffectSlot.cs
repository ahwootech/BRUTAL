// The identity half and the Gain/SendAuto properties are generated. Load is hand-written, and is a
// verb rather than a settable Effect property because the native call COPIES the effect's
// parameters at call time - property-assignment syntax would falsely suggest a live link.

namespace Brutal.OpenAlApi;

public readonly partial struct AlAuxiliaryEffectSlot
{
    /// <summary>
    ///     Loads an effect into the slot (<c>AL_EFFECTSLOT_EFFECT</c>). OpenAL copies the effect's
    ///     parameters into the slot NOW: changing the effect's parameters afterwards has no audible
    ///     effect until it is loaded again. Pass <see cref="AlEffect.Null"/> to detach.
    /// </summary>
    public void Load(AlEffect effect)
    {
        Al.PInvoke.AuxiliaryEffectSloti(Name, Al.Constants.AL_EFFECTSLOT_EFFECT, (int)effect.Name);
    }
}
