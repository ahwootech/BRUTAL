namespace Brutal.KtxApi;

public partial struct KtxBasisParams
{
    /// <summary>
    /// Initialises the StructSize field to the correct value.
    /// </summary>
    /// <remarks>
    /// This constructor only runs when you call <c>new KtxBasisParams()</c> explicitly - it is
    /// bypassed by <c>default(KtxBasisParams)</c>, array elements (<c>new KtxBasisParams[n]</c>),
    /// and struct fields in other types, all of which leave StructSize at 0. Prefer
    /// <see cref="Create"/> when you're not immediately assigning every field via an object
    /// initializer.
    /// </remarks>
    public unsafe KtxBasisParams()
    {
        StructSize = (uint)sizeof(KtxBasisParams);
    }

    /// <summary>
    /// Creates a KtxBasisParams with StructSize correctly initialised. Preferred over
    /// <c>default(KtxBasisParams)</c> or array/field initialization, which leave StructSize at 0.
    /// </summary>
    public static KtxBasisParams Create() => new();
}
