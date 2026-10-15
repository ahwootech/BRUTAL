namespace Brutal.KtxApi;

public partial struct KtxAstcParams
{
    /// <summary>
    /// Initialises the StructSize field to the correct value.
    /// </summary>
    /// <remarks>
    /// This constructor only runs when you call <c>new KtxAstcParams()</c> explicitly - it is
    /// bypassed by <c>default(KtxAstcParams)</c>, array elements (<c>new KtxAstcParams[n]</c>),
    /// and struct fields in other types, all of which leave StructSize at 0. Prefer
    /// <see cref="Create"/> when you're not immediately assigning every field via an object
    /// initializer.
    /// </remarks>
    public unsafe KtxAstcParams()
    {
        StructSize = (uint)sizeof(KtxAstcParams);
    }

    /// <summary>
    /// Creates a KtxAstcParams with StructSize correctly initialised. Preferred over
    /// <c>default(KtxAstcParams)</c> or array/field initialization, which leave StructSize at 0.
    /// </summary>
    public static KtxAstcParams Create() => new();
}
