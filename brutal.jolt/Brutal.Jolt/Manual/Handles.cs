namespace Brutal.JoltApi;

// Hand-written surface over the manual imports in Manual/Jolt.PInvoke.cs. The base-type up-casts and
// the Result-unwrapping CreateShape are generated (see Generator.Interop.cs); only the pieces the
// generator can't express live here: the Factory static-instance accessors and the convenience
// forwarders that let a derived *ShapeSettings call an inherited method directly.

public readonly partial struct Factory
{
    /// <summary>Mirrors <c>JPH::Factory::sInstance</c>.</summary>
    /// <remarks>
    /// Assigning hands the factory to the global, and the getter borrows it back. Tear it down with
    /// <see cref="DestroyInstance"/>; never <c>Dispose</c> the handle you assigned or the one you get back.
    /// </remarks>
    public static Factory Instance
    {
        get => Jolt.PInvoke.Factory_GetInstance();
        set => Jolt.PInvoke.Factory_SetInstance(value);
    }

    /// <summary>Deletes the global factory instance and clears <see cref="Instance"/>.</summary>
    public static void DestroyInstance() => Jolt.PInvoke.Factory_DestroyInstance();
}

// Convenience forwarders: an implicit up-cast makes a derived handle usable where a base is expected,
// but C# won't surface the base's methods on the derived type, so the common ones are forwarded here.
// Every concrete *ShapeSettings overrides Create, so CreateShape needs no forwarding.
public readonly partial struct BoxShapeSettings
{
    /// <inheritdoc cref="ConvexShapeSettings.SetDensity" />
    public void SetDensity(float density) => ((ConvexShapeSettings)this).SetDensity(density);
}

public readonly partial struct StaticCompoundShapeSettings
{
    /// <inheritdoc cref="CompoundShapeSettings.AddShape(float3, floatQuat, Shape, uint)" />
    public void AddShape(float3 position, floatQuat rotation, Shape shape, uint userData = 0) =>
        ((CompoundShapeSettings)this).AddShape(position, rotation, shape, userData);
}

public readonly partial struct SphereShapeSettings
{
    /// <inheritdoc cref="ConvexShapeSettings.SetDensity" />
    public void SetDensity(float density) => ((ConvexShapeSettings)this).SetDensity(density);
}
