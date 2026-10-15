using System.Runtime.InteropServices;

namespace Brutal.FmodApi.Studio;

/// <summary>
/// UserProperty struct. The Value field is a union of different types at the same address, only
/// one should be set at a time.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct UserProperty
{
    /// <summary>
    ///
    /// </summary>
    [FieldOffset(0)]
    public byte* Name;

    /// <summary>
    ///
    /// </summary>
    [FieldOffset(8)]
    public UserPropertyType Type;

    // Explicit alignment of each Value field in the 'union' to the same address
    // Union aligned to the next 8 byte increment due to C++ alignment of its largest type (pointer)

    /// <summary>
    ///
    /// </summary>
    [FieldOffset(16)]
    public int IntValue;

    /// <summary>
    ///
    /// </summary>
    [FieldOffset(16)]
    public bool BoolValue;

    /// <summary>
    ///
    /// </summary>
    [FieldOffset(16)]
    public float FloatValue;

    /// <summary>
    ///
    /// </summary>
    [FieldOffset(16)]
    public byte* StringValue;
}
