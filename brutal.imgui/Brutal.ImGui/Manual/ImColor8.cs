namespace Brutal.ImGuiApi;

// TODO: byte4 converts implicitly to uint... so why not from uint as well?

/// <summary>
/// 8-bit per channel color, for interop.
/// Converts to/from uint, byte4, and float4.
/// </summary>
public struct ImColor8
{
    private byte4 _value;

    private ImColor8(uint value)
    {
        _value = Unsafe.As<uint, byte4>(ref value);
    }

    private ImColor8(byte4 value)
    {
        _value = value;
    }

    private ImColor8(float4 value)
    {
        _value = byte4.Pack(value, Pack.Float.Normalize);
    }

    public ImColor8(byte r, byte g, byte b, byte a = 255)
        : this(new byte4(r, g, b, a)) { }

    public static implicit operator ImColor8(in uint value) => new(value);

    public static implicit operator ImColor8(in byte4 value) => new(value);

    public static explicit operator ImColor8(in float4 value) => new(value);

    public static implicit operator ImColor8(in Color.Preset value) => new(value.AsByte4);

    public static implicit operator ImColor8(in ImGuiCol value) => ImGui.GetColorU32(value);

    // TODO: this is just here to make PInvoke easier but I don't like it...
    public static implicit operator uint(in ImColor8 value) => value._value;

    //public static implicit operator byte4(in ImColor8 value) => value._value;

    public readonly uint AsUint() => _value;

    public readonly byte4 AsByte4() => _value;

    public readonly float4 AsFloat4()
    {
        float4 result;
        result.X = _value.X / 255f;
        result.Y = _value.Y / 255f;
        result.Z = _value.Z / 255f;
        result.W = _value.W / 255f;
        return result;
    }

    public ImColor8 RGBA
    {
        get => _value.RGBA;
        set => _value.RGBA = value._value.RGBA;
    }

    public ImColor8 ARGB
    {
        get => _value.ARGB;
        set => _value.ARGB = value._value.ARGB;
    }

    public static readonly ImColor8 Black = new(0, 0, 0);
    public static readonly ImColor8 White = new(255, 255, 255);
    public static readonly ImColor8 Red = new(255, 0, 0);
    public static readonly ImColor8 Green = new(0, 255, 0);
    public static readonly ImColor8 Blue = new(0, 0, 255);
}
